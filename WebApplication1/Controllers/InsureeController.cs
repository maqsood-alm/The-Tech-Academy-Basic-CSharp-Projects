using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using System.Collections.Generic;

namespace WebApplication1.Controllers
{
    public class InsureeController : Controller
    {
        // Temporary in-memory storage
        private static List<Insuree> insurees = new List<Insuree>();

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // Quote calculation
                decimal quote = 50;
                int age = System.DateTime.Now.Year - insuree.DateOfBirth.Year;
                if (insuree.DateOfBirth > System.DateTime.Now.AddYears(-age)) age--;

                if (age <= 18) quote += 100;
                else if (age <= 25) quote += 50;
                else quote += 25;

                if (insuree.CarYear < 2000) quote += 25;
                if (insuree.CarYear > 2015) quote += 25;

                if (insuree.CarMake.ToLower() == "porsche") quote += 25;
                if (insuree.CarMake.ToLower() == "porsche" && insuree.CarModel.ToLower() == "911 carrera") quote += 25;

                quote += insuree.SpeedingTickets * 10;

                if (insuree.DUI) quote *= 1.25m;
                if (insuree.CoverageType.ToLower() == "full") quote *= 1.5m;

                insuree.Quote = quote;

                // Save to temporary list
                insurees.Add(insuree);

                return RedirectToAction("Admin");
            }

            return View(insuree);
        }

        public IActionResult Admin()
        {
            return View(insurees);
        }
    }
}