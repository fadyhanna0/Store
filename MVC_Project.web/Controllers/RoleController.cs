using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC_Project.Core.Interfaces;
using MVC_Project.Core.Models;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Project.web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> RoleManager;
        private readonly IUnitOfWork _unitOfWork;
        public RoleController(RoleManager<IdentityRole> _RoleManager, IUnitOfWork unitOfWork)
        {
            RoleManager = _RoleManager;
            _unitOfWork = unitOfWork;
        }

        public IActionResult AddRole()
        {
            List<Category> categories = _unitOfWork.CategoryRepository.GetAll().ToList();
            ViewData["categories"] = categories;
            return View("AddRole");
        }


        [HttpPost]
        public async Task<IActionResult> AddRole(RoleVM newRole)
        {
            List<Category> categories = _unitOfWork.CategoryRepository.GetAll().ToList();
            ViewData["categories"] = categories;
            if (ModelState.IsValid == true)
            {
                IdentityRole role = new IdentityRole()
                {
                    Name = newRole.RoleName
                };

                IdentityResult result = await RoleManager.CreateAsync(role);

                if (result.Succeeded)
                {
                    return View();
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

            }

            return View(newRole);
        }

    }
}
