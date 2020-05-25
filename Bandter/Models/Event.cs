using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bandter.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public int LocationId { get; set; }

        [DisplayFormat(DataFormatString ="{MM/dd/yyyy}")]
        public DateTime EventDate { get; set; }
        public string Description { get; set; }
        public string Zipcode { get; set; }
        public int? Going { get; set; }

    }
}
