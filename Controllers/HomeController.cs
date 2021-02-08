using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MultiPageWebApp.Models;

namespace MultiPageWebApp.Controllers
{
    public class HomeController : Controller
    {
        private ContactsContext context { get; set; }

        public HomeController(ContactsContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var contacts = context.Contacts.OrderBy(c => c.Name).ToList();
            return View(contacts);
        }
    }
}
