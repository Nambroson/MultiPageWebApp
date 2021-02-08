using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MultiPageWebApp.Models
{
    public class ContactsContext : DbContext
    {

        public ContactsContext(DbContextOptions<ContactsContext> options)
            : base(options)
        { }

        public DbSet<Contacts> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contacts>().HasData(
                new Contacts
                {
                    ContactsId = 1,
                    Name = "Hayley",
                    Number = "515-555-1234",
                    Address = "1122 Over Here Dr",
                    Note = "Wifey",
                },
                new Contacts
                {
                    ContactsId = 2,
                    Name = "Griff",
                    Number = "515-555-4321",
                    Address = "123 Over There Ct",
                    Note = "Son",
                },
                new Contacts
                {
                    ContactsId = 3,
                    Name = "Beck",
                    Number = "515-555-1324",
                    Address = "987 Where St",
                    Note = "Son",
                },
                new Contacts
                {
                    ContactsId = 4,
                    Name = "Wally",
                    Number = "515-555-9876",
                    Address = "7890 Doghouse Ln",
                    Note = "Woof",
                }
                );
        }
    }
}
