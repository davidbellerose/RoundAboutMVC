using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RoundAboutMVC.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace RoundAboutMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FBPage()
        {
            RoundAbout model = new();
            model.RoundValue = 3;
            model.AboutValue = 5;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult FBPage(RoundAbout roundAbout)
        {
            List<string> raItems = new();
            bool round;
            bool about;

            for (int i = 1; i <= 100; i++)
            {
                round = (i % roundAbout.RoundValue == 0);
                about = (i % roundAbout.AboutValue == 0);

                if (round == true && about == true)
                {
                    raItems.Add("RoundAbout");
                }
                else if (round == true)
                {
                    raItems.Add("Round");
                }
                else if (about == true)
                {
                    raItems.Add("About");
                }
                else
                {
                    raItems.Add(i.ToString());
                }
            }

            roundAbout.Result= raItems;

            return View(roundAbout);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
