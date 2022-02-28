using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Project.Core.Interfaces;
using MVC_Project.Core.Models;
using MVC_Project.EF;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC_Project.web.Controllers
{
    public class CustomerMenuController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CustomerMenuController(IUnitOfWork unitOfWork)
        {
                _unitOfWork = unitOfWork;
        }
       public IActionResult Product(int id)
        {
            List<Food> food= _unitOfWork.FoodList.GetAll(x=>x.Category_Id==id).ToList();
            List<Category> categories = _unitOfWork.CategoryRepository.GetAll().ToList();
            ViewData["categories"] = categories;
            return View(food);
        }
        [Authorize]

        public IActionResult AddInBasket([FromRoute]int id, int quantity)
        {
            string CustomerId = Request.Cookies["CustomerId"].ToString();
            var OldOrder=_unitOfWork.OrderRepository.GetById(s=>s.Customer_Id==CustomerId && s.Accepted==false);
            if (OldOrder == null)
            {
                Order neworder = new();
                neworder.Customer_Id = CustomerId;
                neworder.Accepted = false;
                neworder.DateTime = DateTime.Now.ToString();
                _unitOfWork.OrderRepository.Add(neworder);
                _unitOfWork.Complete();
                OldOrder = _unitOfWork.OrderRepository.GetById(s => s.Customer_Id == CustomerId && s.Accepted == false);
            }
            var OldOrderItem = _unitOfWork.OrderItemRepository.GetById(s => s.Order_Id == OldOrder.Id && s.Food_Id == id);

            if (OldOrderItem == null)
            {
                 Food food=_unitOfWork.FoodList.GetById(id);
                OrderItem orderitem = new();
                orderitem.Food_Id = id;
                orderitem.Order_Id = OldOrder.Id;
                orderitem.quantity = quantity;
                orderitem.Total_item_price = quantity*food.Price;
                _unitOfWork.OrderItemRepository.Add(orderitem);
                _unitOfWork.Complete();
            }
            List<Category> categories = _unitOfWork.CategoryRepository.GetAll().ToList();
            ViewData["categories"] = categories;
            return RedirectToAction("DisplayMenu");
        }
        [Authorize]

        public IActionResult Basket()
        {
            decimal TotalPrice=0;
            string CustomerId = Request.Cookies["CustomerId"].ToString();
           var OldOrder = _unitOfWork.OrderRepository.GetById(s => s.Customer_Id == CustomerId && s.Accepted == false);
            List<OrderItem> OrderItem = new List<OrderItem>();
            if (OldOrder != null)
            {
                OrderItem = _unitOfWork.OrderItem.GetOrderItems(s => s.Order_Id == OldOrder.Id).ToList();
            }
                foreach (var item in OrderItem)
                {
                    TotalPrice += item.Total_item_price;
                }
                ViewData["TotalPrice"] = TotalPrice;
                var Payment = _unitOfWork.PaymentRepository.GetAll();
                ViewData["Payment"] = Payment;

            List<Category> categories = _unitOfWork.CategoryRepository.GetAll().ToList();
            ViewData["categories"] = categories;
            return View(OrderItem); 
        }
        [Authorize]

        public IActionResult DeleteItem([FromRoute]int id,int FoodId)
        {
            OrderItem orderItem = _unitOfWork.OrderItemRepository.GetById(s => s.Order_Id == id && s.Food_Id == FoodId);
            _unitOfWork.OrderItemRepository.Delete(orderItem);
            _unitOfWork.Complete();
            List<Category> categories = _unitOfWork.CategoryRepository.GetAll().ToList();
            ViewData["categories"] = categories;
            return RedirectToAction("Basket");
        }
        [Authorize]

        public IActionResult Checkout()
        {
            string CustomerId = Request.Cookies["CustomerId"].ToString();
            var OldOrder = _unitOfWork.OrderRepository.GetById(s => s.Customer_Id == CustomerId && s.Accepted == false);
            if (OldOrder != null)
            {
                OldOrder.Accepted = true;
                _unitOfWork.Complete();
                return View();

            }
            List<Category> categories = _unitOfWork.CategoryRepository.GetAll().ToList();
            ViewData["categories"] = categories;
            return RedirectToAction("Basket");

        }
        public IActionResult GetCategoriestoNav()
        {
            List<Category> categories = _unitOfWork.CategoryRepository.GetAll().ToList();
            ViewData["categories"] = categories;

            return View("DisplayMenu");
        }












        //public IActionResult SetCookies()
        //{
        //    CookieOptions cookieOptions = new CookieOptions();
        //    cookieOptions.Expires = System.DateTimeOffset.Now.AddDays(10);
        //    Response.Cookies.Append("CustomerId", "10", cookieOptions);
        //    return View();
        //}
        //public IActionResult GetCookies()
        //{
        //    string CustomerId = Request.Cookies["CustomerId"].ToString();
        //    return View();
        //}

    }
}