using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetSmartz.Application.Interfaces;
using NetSmartz.Application.Models;

namespace NetSmartz.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _iProductService;
        private readonly ICategoryService _iCategoryService;

        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            _iProductService = productService;
            _iCategoryService = categoryService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View("Index", _iProductService.Get());

        }

        public IActionResult Add()
        {
            var list = _iCategoryService.Get();
            ProductModel productModel = new ProductModel()
            {
                CategoryList = list
                //new System.Web.Mvc.SelectList(_iCategoryService.Get().Select(s=> new {s.CategoryId,s.Name}).ToList(), "CategoryId", "Name")

            };
            return View("Create", productModel);
        }
        public IActionResult Edit(int id)
        {
            var result = _iProductService.Get().Where(x => x.ProductId == id).FirstOrDefault();
            {
                if (result != null)
                {
                    result.CategoryList = _iCategoryService.Get();

                    return View("Create", result);

                }
                else
                {
                    return NotFound();
                }
            }
        }
        [HttpPost]
        public IActionResult Create(ProductModel productModel)
        {

            TempData["message"] = _iProductService.AddUpdate(productModel).Message;
  
            return RedirectToAction("Index");

            //  return View("Index", _iCategoryService.Create(categoryModel));
        }


        public IActionResult Delete(int id)
        {
            _iProductService.Delete(id);
            TempData["deletemessage"] = "Category deleted successfully.";

            return RedirectToAction("Index");
        }
    }
}
