using Entities.Models;
using Entities.RequestParameters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Contracts;
using Services.Contracts;
using Store.Models;

namespace Store.Controllers
{
    public class ProductController : Controller
    {
        private readonly IServiceManager _manager;

        public ProductController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index(ProductRequestParameters p)
        {

            var products = _manager.ProductService.GetAllProductsWitihDetails(p);
            var pagination = new Pagination()
            {
                CurrenPage = p.PageNumber,
                ItemPerPage = p.PageSize,
                TotalItmes= _manager.ProductService.GetAllProcucts(false).Count()
            };
            return View(new ProductListViewModel()
            {
                Products= products,
                Pagination = pagination
            });

        }
        public IActionResult Get([FromRoute(Name ="id")]int id)
        {
            var model = _manager.ProductService.GetOneProduct(id, false);
            ViewData["Title"] = model?.ProductName;
            return View(model);

        }
    }
}
