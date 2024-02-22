using Microsoft.AspNetCore.Mvc;
using Store.Models;
using System.Diagnostics;

namespace Store.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            ViewData["Title"] = "Welcome";
            return View();
        }
      
    }
}