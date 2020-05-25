using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bandter.ViewModels;
using Microsoft.EntityFrameworkCore;
using Bandter.Models;

namespace Bandter.Controllers
{
    public class MainController : Controller
    {
        private BanderDbContext context;

        public MainController(BanderDbContext db)
        {
            context = db;
        }

        public IActionResult UserPage()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EventsView(string zip)
        {
            EventViewModel model = new EventViewModel();
            List<Event> events = new List<Event>();
            model.EventsList = events;
            var city = context.Locations.Where(l => l.Zipcode == zip).FirstOrDefault();
            if(city == null)
            {
                model.CityName = "There are currently no events in this area...";
                return View(model);
            }
            model.CityName = "Events in " + city.City + "...";

            foreach (var e in context.Events)
            {
                if(e.Zipcode == zip)
                {
                    model.EventsList.Add(e);
                }
            }

            return View(model);
        }
    }
}