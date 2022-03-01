using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVC_Project.Core.Interfaces;
using Restaurant.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVC_Project.web.Controllers
{
    [Authorize(Roles ="Admin")]
    public class MenuController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public MenuController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        //this method retun all Categories
        public List<Category> GetCategories()
        {
            List<Category> categories = _unitOfWork.CategoryRepository.GetAll().ToList();
            return categories;
        }

        public IActionResult Dashboard()
        {
            List<Category> categories = _unitOfWork.CategoryRepository.GetAll().ToList();
            ViewData["categories"] = categories;
            return View();
        }
        public IActionResult ProductList()
        {
            List<Category> categories = _unitOfWork.CategoryRepository.GetAll().ToList();
            ViewData["categories"] = categories;
            var list = _unitOfWork.ProductList.GetFood();
            //     var food1 = _unitOfWork.ProductList.GetById(f => f.Id == 2);

            return View(list);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            ViewData["categories"] = GetCategories();
            Product food = new();
            return View(food);
        }
        [HttpPost]
        public IActionResult AddFood(Product food)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.ProductList.Add(food);
                _unitOfWork.Complete();
                return RedirectToAction("FoodList");
            }
            ViewData["categories"] = GetCategories();
            return View("AddFood",food);
        }
        /////Edit Product
        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            ViewData["categories"] = GetCategories();
            Product food = _unitOfWork.ProductList.GetById(id);
            return View(food);
        }
        [HttpPost]

        public IActionResult EditProduct(Product food)
        {
            List<Category> categories = _unitOfWork.CategoryRepository.GetAll().ToList();
            ViewData["categories"] = categories;
            _unitOfWork.ProductList.Update(food);
            _unitOfWork.Complete();
            return RedirectToAction("FoodList");
        }
        //...........................................................
        // Delete Product
        public IActionResult DeleteProduct(int id)
        {
            List<Category> categories = _unitOfWork.CategoryRepository.GetAll().ToList();
            ViewData["categories"] = categories;
            Product product = _unitOfWork.ProductList.GetById(id);
            _unitOfWork.ProductList.Delete(product);
            _unitOfWork.Complete();
            return RedirectToAction("ProductList");
        }
     
    }


}
