﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2_W1830820
{
    public class EventDetails
    {
        public int Id{get;set;}
        public string EventOccurrence { get; set; }
        public DateTime StartDate { get; set; }
        public int NumberOfAdditionalTimesRecurring { get; set; }
        public string Description { get; set; }
        public string EventType { get; set; }
    }
}
