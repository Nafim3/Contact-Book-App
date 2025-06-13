using Contact_Book_App.Data;
using Microsoft.AspNetCore.Mvc;
using Contact_Book_App.Models;

namespace Contact_Book_App.Controllers
{
    public class ContactEntryController : Controller
    {
        private readonly ApplicationDbContext Database;

        public ContactEntryController(ApplicationDbContext database)
        {
            Database = database;
        }
        public IActionResult Index()
        {
            List <ContactEntry> contactEntries = Database.ContactEntries.ToList();  

            return View(contactEntries);
        }
    }
}
