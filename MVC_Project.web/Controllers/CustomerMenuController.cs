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
            List<Product> Product = _unitOfWork.ProductList.GetAll(x=>x.Category_Id==id).ToList();
            List<Category> categories = _unitOfWork.CategoryRepository.GetAll().ToList();
            ViewData["categories"] = categories;
            return View(Product);
        }
        [Authorize]

        public IActionResult AddInBasket([FromRoute] int id , int ProductId, int quantity)
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
            var OldOrderItem = _unitOfWork.OrderItemRepository.GetById(s => s.Order_Id == OldOrder.Id && s.Product_Id == ProductId);

            if (OldOrderItem == null)
            {
                 Product food=_unitOfWork.ProductList.GetById(ProductId);
                OrderItem orderitem = new();
                orderitem.Product_Id = ProductId;
                orderitem.Order_Id = OldOrder.Id;
                orderitem.quantity = quantity;
                orderitem.Total_item_price = quantity*food.Price;
                _unitOfWork.OrderItemRepository.Add(orderitem);
                _unitOfWork.Complete();
            }
            if (OldOrderItem != null)
            {
                OldOrderItem.quantity = quantity;
                _unitOfWork.Complete();
            }
                List<Category> categories = _unitOfWork.CategoryRepository.GetAll().ToList();
            ViewData["categories"] = categories;
            //if id == 0 this meaning this request become from ProductDetails View
            if (id == 0)
            {
                 id = ProductId;
                return RedirectToAction("ProductDetails", "CustomerMenu", new { id });
            }
            return RedirectToAction("Product", "CustomerMenu", new { id});
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

        public IActionResult DeleteItem([FromRoute]int id,int ProductId)
        {
            OrderItem orderItem = _unitOfWork.OrderItemRepository.GetById(s => s.Order_Id == id && s.Product_Id == ProductId);
            _unitOfWork.OrderItemRepository.Delete(orderItem);
            _unitOfWork.Complete();
            List<Category> categories = _unitOfWork.CategoryRepository.GetAll().ToList();
            ViewData["categories"] = categories;
            return RedirectToAction("Basket");
        }
        [Authorize]

        public IActionResult Checkout()
        {
            List<Category> categories = _unitOfWork.CategoryRepository.GetAll().ToList();
            ViewData["categories"] = categories;
            string CustomerId = Request.Cookies["CustomerId"].ToString();
            var OldOrder = _unitOfWork.OrderRepository.GetById(s => s.Customer_Id == CustomerId && s.Accepted == false);
            if (OldOrder != null)
            {
                int TotalPrice = 0;
                foreach (var item in OldOrder.OrderItemsList)
                {
                    TotalPrice+= (int)item.Total_item_price;
                }
                OldOrder.Price = TotalPrice;
                OldOrder.Accepted = true;
                OldOrder.DateTime= DateTime.Now.ToString();
                _unitOfWork.Complete();
                return View();

            }
          
            return RedirectToAction("Basket");

        }
        public IActionResult GetCategoriestoNav()
        {
            
            var userIdentity = User.Identity.Name;
            var Role=_unitOfWork.AppUser.Find(x=>x.UserName == userIdentity);
            List<Category> categories = _unitOfWork.CategoryRepository.GetAll().ToList();
            ViewData["categories"] = categories;
            return View("DisplayMenu");
        }
        [Authorize(Roles = "Admin")]
        public IActionResult AllOrders()
        {
            var Order = _unitOfWork.OrderRepository.GetAll(x => x.Accepted == true&&x.Confirmed==null).ToList();
            List<Category> categories = _unitOfWork.CategoryRepository.GetAll().ToList();
            ViewData["categories"] = categories;
            return View(Order);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult AcceptOrders(int id)
        {
            var Order=_unitOfWork.OrderRepository.GetById(x=>x.Id==id);
            Order.Confirmed = true;
            _unitOfWork.Complete();
            return RedirectToAction("AllOrders");
        }
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteOrders(int id)
        {
            var Order = _unitOfWork.OrderRepository.GetById(x => x.Id == id);
            Order.Confirmed = false;
            _unitOfWork.Complete();
            return RedirectToAction("AllOrders");
        }
        [Authorize(Roles = "Admin")]
        public IActionResult ConfirmedOrders()
        { 
            var ConfirmedOrders = _unitOfWork.OrderRepository.GetAll(x => x.Accepted == true && x.Confirmed == true).ToList();
            List<Category> categories = _unitOfWork.CategoryRepository.GetAll().ToList();
            ViewData["categories"] = categories;
            return View(ConfirmedOrders);
        }
        public IActionResult CustomerOrders()
        {
            string CustomerId = Request.Cookies["CustomerId"].ToString();
            var CustomerOrders = _unitOfWork.OrderRepository.GetAll(x => x.Accepted == true && x.Customer_Id==CustomerId).ToList();
            List<Category> categories = _unitOfWork.CategoryRepository.GetAll().ToList();
            ViewData["categories"] = categories;
            return View(CustomerOrders);
        }
        public IActionResult ProductDetails(int id)
        {
            var product=_unitOfWork.ProductList.GetById(id);
            List<Category> categories = _unitOfWork.CategoryRepository.GetAll().ToList();
            ViewData["categories"] = categories;
            return View(product);
        }
        public IActionResult Payment(int id)
        {
            List<Category> categories = _unitOfWork.CategoryRepository.GetAll().ToList();
            ViewData["categories"] = categories;
            return View();
        }

        public IActionResult aboutus(int id)
        {
            List<Category> categories = _unitOfWork.CategoryRepository.GetAll().ToList();
            ViewData["categories"] = categories;
            return View();
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