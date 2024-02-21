using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Store.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class OrderController : Controller
    {
        private readonly IServiceManager _manager;

        public OrderController(IServiceManager manager)
        {
            _manager = manager;
        }


        public IActionResult Index()
        {
            var ordes = _manager.OrderService.Ordes;
            return View(ordes);
        }

        [HttpPost]
        public IActionResult Complete([FromForm] int id) 
        {
            _manager.OrderService.Complate(id);
            return RedirectToAction("Index");
        }
    }
}
