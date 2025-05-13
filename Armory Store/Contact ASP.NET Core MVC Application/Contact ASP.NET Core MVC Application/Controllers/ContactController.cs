using Contact_ASP.NET_Core_MVC_Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Contact_ASP.NET_Core_MVC_Application.Controllers
{
    public class ContactController : Controller
    {
        private readonly string email = "contact@armorystore.com";
        private readonly string address = "Plovdiv, Bulgaria";
        public IActionResult Index()
        {
            ViewData["EmailAddress"] = email;
            ViewBag.Address = address;
            
            return View();
        }

        [HttpPost]
        public IActionResult Index(ContactDto model)
        {
            ViewData["EmailAddress"] = email;
            ViewBag.Address = address;
            
            //checks if the submitted data is valid or not
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            //store the contact data in the database
            ViewBag.SuccessMessage = "Your message is received successfully!";
            ModelState.Clear();

            return View();
        }
    }
}
