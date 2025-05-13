using System.ComponentModel.DataAnnotations;

namespace Contact_ASP.NET_Core_MVC_Application.Models
{
    public class ContactDto
    {
        [Required(ErrorMessage = "The First Name is required")]
        public string FirstName { get; set; } = "";

        [Required(ErrorMessage = "The Last Name is required")]
        public string LastName { get; set; } = "";

        [Required(ErrorMessage = "The Email is required")]
        [EmailAddress]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "The Message is required")]
        public string Message { get; set; } = "";
    }
}
