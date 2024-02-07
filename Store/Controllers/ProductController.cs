using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Contracts;
using Services.Contracts;

namespace Store.Controllers
{
    public class ProductController : Controller
    {
        private readonly IServiceManager _manager;

        public ProductController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {

            var model = _manager.ProductService.GetAllProcucts(false);
            return View(model);

        }
        public IActionResult Get([FromRoute(Name ="id")]int id)
        {
            var model = _manager.ProductService.GetOneProduct(id, false);

            return View(model);

        }
    }
}
