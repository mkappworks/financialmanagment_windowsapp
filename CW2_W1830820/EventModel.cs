using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2_W1830820
{
   public class EventModel
    {
        public int EventOccurrence { get; set; }
        public int EventOccurrenceType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public String Description { get; set; }
        public int EventType { get; set; }
    }
}
