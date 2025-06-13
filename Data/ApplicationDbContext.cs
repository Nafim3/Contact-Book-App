using Microsoft.EntityFrameworkCore;
using Contact_Book_App.Models;

namespace Contact_Book_App.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ContactEntry> ContactEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ContactEntry>().HasData(
                
                new ContactEntry
                {
                    Id = 1, 
                    FirstName = "Amjad", 
                    LastName = "Mustafa", 
                    PhoneNumber= "048917387135", 
                    Email = "ams4@gmail.com",
                    Generated = new DateTime(2025,6,7)
                },
                
                new ContactEntry
                {
                    Id = 2,
                    FirstName = "Lamine",
                    LastName = "Yamal",
                    PhoneNumber = "123456789014",
                    Email = "lY6@gmail.com",
                    Generated = new DateTime(2025, 6, 7)
                },

                new ContactEntry 
                {
                    Id = 3,
                    FirstName = "Kamran",
                    LastName = "",
                    PhoneNumber = "891084735184",
                    Email = "kn@gmail.com",
                    Generated = new DateTime(2025,6,8)
                
                }

                );


        }
    }
}
