using EnvatoMarket.Class.DAL;
using EnvatoMarket.Class.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnvatoMarket.Class.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index([FromForm]ContactUs contactUs)
        {
            ContactUs dbContactUs = new ContactUs();
            dbContactUs.Id = contactUs.Id;
            dbContactUs.Name = contactUs.Name;
            dbContactUs.PhoneNumber = contactUs.PhoneNumber;
            dbContactUs.Email = contactUs.Email;
            dbContactUs.Subject = contactUs.Subject;
            dbContactUs.Message = contactUs.Message;

            _context.ContactUs.Add(dbContactUs);
            _context.SaveChanges();

            return Ok();
        }


    }
}
