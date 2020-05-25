using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Bandter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bandter.Controllers
{
    public class EventController : Controller
    {
        private BanderDbContext context;

        public EventController(BanderDbContext db)
        {
            context = db;
        }

        public IActionResult CreateEvent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateEvent(string eventTitle, DateTime eventDate, string eventDescription, string locationStreet, string locationCity, string locationState, string locationZip)
        {
            Location newLocation = new Location()
            {
                Street = locationStreet,
                City = locationCity,
                State = locationState,
                Zipcode = locationZip
            };
            context.Locations.Add(newLocation);
            context.SaveChanges();
            Event newEvent = new Event()
            {
                Title = eventTitle,
                EventDate = eventDate,
                LocationId = newLocation.LocationId,
                Description = eventDescription,
                Zipcode = locationZip,
                Going = 0
            };
            context.Events.Add(newEvent);
            context.SaveChanges();

            return RedirectToAction("UserPage", "Main");
        }

        [HttpPost]
        public IActionResult RSVP(int eventId)
        {
            var rsvpEvent = context.Events.Where(e => e.EventId == eventId).FirstOrDefault();
            rsvpEvent.Going++;
            context.SaveChanges();
            var route = rsvpEvent.Zipcode;

            return RedirectToAction("EventsView", "Main", new { zip = route });
        }
    }
}