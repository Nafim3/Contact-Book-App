using System.ComponentModel.DataAnnotations;
namespace Contact_Book_App.Models
{
    public class ContactEntry
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="The First Name field is required")]
        public string? FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage ="The Last Name field is required")]
        public string? LastName { get; set; }

        [Required(ErrorMessage ="The Phone Number field is required")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Phone number must be exactly 11 digits")]
        public string? PhoneNumber { get; set;}

        [Required(ErrorMessage = "The Email field is required")]
        [EmailAddress(ErrorMessage ="Enter a valid email address")]
        public string? Email { get; set; }

        [Required(ErrorMessage ="Select a date from the calendar shown on the right side of the box above")]
        public DateTime Generated { get; set; } = DateTime.Now;

        
    }
}
