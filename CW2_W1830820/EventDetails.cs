using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2_W1830820
{
   public class EventDetails
    {
        public string EventOccurrence { get; set; }
       // public string EventOccurrenceType { get; set; }
        public DateTime StartDate { get; set; }
        public int NumberOfAdditionalTimesRecurring { get; set; }
        public String Description { get; set; }
        public string EventType { get; set; }
    }
}
