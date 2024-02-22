using Entities.Models;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Services.Contracts;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Entities.RequestParameters;
using Store.Models;

namespace Store.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        private readonly IServiceManager _manager;

        public ProductController(IServiceManager manager)
        {
            _manager = manager;
        }

   
        public IActionResult Index([FromQuery]ProductRequestParameters p)
        {
            ViewData["Title"] = "Products";
            var products = _manager.ProductService.GetAllProductsWitihDetails(p);
            var pagination = new Pagination()
            {
                CurrenPage = p.PageNumber,
                ItemPerPage = p.PageSize,
                TotalItmes = _manager.ProductService.GetAllProcucts(false).Count()
            };
            return View(new ProductListViewModel()
            {
                Products = products,
                Pagination = pagination
            });
        }
       

        public IActionResult Create() 
        {
            ViewBag.Categories = GetCategoriesSelectList();

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] ProductDtoForInsertion productDto,IFormFile file)
        {
            if (ModelState.IsValid)
            {
                //file operation
                string path = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot", "images", file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                productDto.ImageUrl = String.Concat("/images/", file.FileName);
                TempData["success"] = $"{productDto.ProductName} has been created.";
                _manager.ProductService.CreateOneProduct(productDto);
                return RedirectToAction("Index");
            }
            return View();
        }


        private SelectList GetCategoriesSelectList()
        {
            return new SelectList(_manager.CategoryService.GetAllCategories(false),
                "CategoryId",
                "CategoryName", "1");
        }

  

        public IActionResult Update([FromRoute(Name ="id")]int id) 
        {
            ViewBag.Categories = GetCategoriesSelectList();
            var model=_manager.ProductService.GetOneProductForUpdate(id,false);
            ViewData["Title"] = model?.ProductName;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update([FromForm]ProductDtoForUpdate productDto,IFormFile file) 
        {
            if (ModelState.IsValid) 
            {
                //file operation
                string path = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot", "images", file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                productDto.ImageUrl = String.Concat("/images/", file.FileName);


                _manager.ProductService.UpdateOneProduct(productDto);
                return RedirectToAction("Index");
            }
            return View();
        }


        [HttpGet]
        public IActionResult Delete([FromRoute(Name = "id")] int id) 
        {
            _manager.ProductService.DeleteOneProduct(id);
            TempData["danger"] = "The product has benn removed.";
            return RedirectToAction("Index");
        }

  
            
    }
}
