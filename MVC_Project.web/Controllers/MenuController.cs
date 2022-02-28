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
        public IActionResult FoodList()
        {

            var list = _unitOfWork.FoodList.GetFood();
            //     var food1 = _unitOfWork.FoodList.GetById(f => f.Id == 2);

            return View(list);
        }
        [HttpGet]
        public IActionResult AddFood()
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
                _unitOfWork.FoodList.Add(food);
                _unitOfWork.Complete();
                return RedirectToAction("FoodList");
            }
            ViewData["categories"] = GetCategories();
            return View("AddFood",food);
        }
        /////Edit Food
        [HttpGet]
        public IActionResult EditFood(int id)
        {
            ViewData["categories"] = GetCategories();
            Product food = _unitOfWork.FoodList.GetById(id);
            return View(food);
        }
        [HttpPost]

        public IActionResult EditFood(Product food)
        {
            _unitOfWork.FoodList.Update(food);
            _unitOfWork.Complete();
            return RedirectToAction("FoodList");
        }
        //...........................................................
        // Delete Food
        public IActionResult DeleteFood(int id)
        {
            Product food = _unitOfWork.FoodList.GetById(id);
            _unitOfWork.FoodList.Delete(food);
            _unitOfWork.Complete();
            return RedirectToAction("FoodList");
        }
     
    }


}
