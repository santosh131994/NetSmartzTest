using Microsoft.AspNetCore.Mvc;
using NetSmartz.Application.Interfaces;
using NetSmartz.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NetSmartz.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _iCategoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _iCategoryService = categoryService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View("Index", _iCategoryService.Get());

        }

        public IActionResult Add()
        {
            return View("Create");
        }
        public IActionResult Edit(int id)
        {
            var result = _iCategoryService.Get().Where(x => x.CategoryId == id).FirstOrDefault();
            {
                if (result != null)
                {
                    result.PriceRange = Convert.ToInt32(result.PriceRange);
                    return View("Create",result);

                }
                else
                {
                    return NotFound();
                }
            }
        }
        [HttpPost]
        public IActionResult Create(CategoryModel categoryModel)
        {
            TempData["message"] = _iCategoryService.AddUpdate(categoryModel).Message;
            return RedirectToAction("Index");

          //  return View("Index", _iCategoryService.Create(categoryModel));
        }
     
        
        public IActionResult Delete(int id)
        {
            _iCategoryService.Delete(id);
            TempData["deletemessage"] = "Category deleted successfully.";

            return RedirectToAction("Index");
        }
    }
}