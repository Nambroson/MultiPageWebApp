using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MultiPageWebApp.Models;

namespace MultiPageWebApp.Controllers
{
    public class ContactsController : Controller
    {
        private ContactsContext context { get; set; }

        public ContactsController(ContactsContext ctx)
        {
            context = ctx;
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Contacts());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var contacts = context.Contacts.Find(id);
            return View(contacts);
        }

        [HttpPost]
        public IActionResult Edit(Contacts contacts)
        {
            if (ModelState.IsValid)
            {
                if (contacts.ContactsId == 0)
                    context.Contacts.Add(contacts);
                else
                    context.Contacts.Update(contacts);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (contacts.ContactsId == 0) ? "Add" : "Edit";
                return View(contacts);
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = context.Contacts.Find(id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(Contacts contacts)
        {
            context.Contacts.Remove(contacts);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
