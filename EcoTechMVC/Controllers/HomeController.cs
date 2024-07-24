using EcoTechMVC.Models;
using EcoTechMVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EcoTechMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContactFormService _contactFormService;

        public HomeController(IContactFormService contactFormService)
        {
            _contactFormService = contactFormService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("/om-oss")]
        public IActionResult AboutPage()
        {
            return View();
        }


        [Route("/medarbetare")]
        public IActionResult EmployeesPage()
        {
            return View();
        }


        [Route("/kontakta-oss")]
        public IActionResult ContactPage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PostContact(ContactForm model)
        {
            if (ModelState.IsValid)
            {
                await _contactFormService.SaveContactFormAsync(model);
                return RedirectToAction("ThankYouPage");
            }
            return View(model);
        }

        [Route("/tack")]
        public IActionResult ThankYouPage()
        {
            return View();
        }


    }
}
