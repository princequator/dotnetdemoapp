using DutchTreats.Services;
using DutchTreats.viewmodels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DutchTreats.controllers
{
    public class AppController : Controller
    {
        private readonly IMailService mailService;

        public AppController(IMailService mailService)
        {
            this.mailService = mailService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                // send the email
                mailService.SendMessage("prince@gmail.com", model.subject, model.message);
                ModelState.Clear();
            }
            else
            {
                // show the errors
            }
            ViewBag.MailSent = "Mail Sent";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";
            return View();  
        }
    }
}
