using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Services.Contracts;

namespace Store.Components
{
    public class CategoriesMenuViewComponent : ViewComponent
    {
        private readonly IServiceManager _managar;

        public CategoriesMenuViewComponent(IServiceManager managar)
        {
            _managar = managar;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _managar.CategoryService.GetAllCategory(false);
            return View(categories);
        }
    }
}
