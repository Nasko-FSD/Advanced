using Microsoft.AspNetCore.Mvc;

namespace Contact_ASP.NET_Core_MVC_Application.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/allProducts");
            var imageFiles = Directory.GetFiles(imagePath)
                .Select(Path.GetFileName)
                .ToList();

            return View(imageFiles);
        }
    }
}
