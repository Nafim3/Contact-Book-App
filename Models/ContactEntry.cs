using System.ComponentModel.DataAnnotations;
namespace Contact_Book_App.Models
{
    public class ContactEntry
    {
        public int Id { get; set; }

        [Required]
        public string? FirstName { get; set; } = string.Empty;

        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? PhoneNumber { get; set;}

        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public DateTime Generated { get; set; } = DateTime.Now;

        
    }
}
