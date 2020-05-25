using Bandter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bandter.ViewModels
{
    public class EventViewModel
    {
        public List<Event> EventsList { get; set; }
        public string CityName { get; set; }
    }
}
