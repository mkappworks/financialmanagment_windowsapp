using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CW2_W1830820
{
    class EventModel
    {
        public void SaveEvent(EventDetails eventDetails)
        {
            /*
            Event event = new Event();

        event.EventOccurrence = eventDetails.EventOccurrence;
        event.StartDate = eventDetails.StartDate;
        event.NumberOfAdditionalTimesRecurring = eventDetails.NumberOfAdditionalTimesRecurring;
        event.Description = eventDetails.Description;
        event.EventType = eventDetails.EventType;

        MyDatabaseFileEntities db = new MyDatabaseFileEntities();

        db.Events.Add(event);
        db.SaveChanges();
            */
        }

        public void EditEvent(EventDetails eventDetails)
        {
            /*
            MyDatabaseFileEntities db = new MyDatabaseFileEntities();

            Event event = db.Events.Find(eventDetails.Id);
        
        event.EventOccurrence = eventDetails.EventOccurrence;
        event.StartDate = eventDetails.StartDate;
        event.NumberOfAdditionalTimesRecurring = eventDetails.NumberOfAdditionalTimesRecurring;
        event.Description = eventDetails.Description;
        event.EventType = eventDetails.EventType;

        db.SaveChanges();
            */
        }

        public dynamic GetEvent()
        {
            MyDatabaseFileEntities db = new MyDatabaseFileEntities();

            return db.Events;
        }

        public void DeleteEvent(int id)
        {
            /*
            MyDatabaseFileEntities db = new MyDatabaseFileEntities();

            Event event = db.Events.Find(id);
            db.Events.Remove(event);
            db.SaveChanges();
            */
        }

    }
}

