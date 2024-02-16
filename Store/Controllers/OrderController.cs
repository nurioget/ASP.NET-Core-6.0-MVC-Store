using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Store.Controllers
{
    public class OrderController : Controller
    {
         private readonly IServiceManager _maager;
        private readonly Cart _cart;

        public OrderController(IServiceManager maager
            , Cart cart)
        {
            _maager = maager;
            _cart = cart;
        }

        public ViewResult Checkout()=>View(new Order());

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Checkout([FromForm]Order order)
        {
            if (_cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sory ,your cart is empty. ");
            }

            if (ModelState.IsValid)
            {
                order.Lines = _cart.Lines.ToArray();
                _maager.OrderService.SaveOrder(order);
                _cart.Clear();
                return RedirectToPage("/Complete", new {OrderId=order.OrderId});
            }

            else
            {
                return View();
            }
        }
    }
}
