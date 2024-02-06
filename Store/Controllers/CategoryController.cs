using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;

namespace Store.Controllers
{
    public class CategoryController : Controller
    {
        private IRepositoryManager _maneger;

        public CategoryController(IRepositoryManager maneger)
        {
            _maneger = maneger;
        }
        public IActionResult Index()
        {
            var model = _maneger.Category.FindAll(false);
            return View(model);
        }
    }
}
