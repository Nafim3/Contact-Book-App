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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ContactEntry CEO)
        {
            Database.ContactEntries.Add(CEO); // Add the new contact entry to the database context
            Database.SaveChanges(); // Save changes to the database
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id==0)
            {
                return NotFound();
            }

            ContactEntry? contactEntry = Database.ContactEntries.Find(id);

            if (contactEntry == null)
            {
                return NotFound();
            }

            return View(contactEntry);
        }

        [HttpPost]
        public IActionResult Edit(ContactEntry CEO)
        {
            Database.ContactEntries.Update(CEO); // updates the new contact entry to the database context
            Database.SaveChanges(); // Save changes to the database
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            ContactEntry? contactEntry = Database.ContactEntries.Find(id);

            if (contactEntry == null)
            {
                return NotFound();
            }

            return View(contactEntry);
        }

        [HttpPost]
        public IActionResult Delete(ContactEntry CEO)
        {
            Database.ContactEntries.Remove(CEO); // updates the new contact entry to the database context
            Database.SaveChanges(); // Save changes to the database
            return RedirectToAction("Index");
        }

    }
}
