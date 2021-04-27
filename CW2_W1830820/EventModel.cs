using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CW2_W1830820
{
    public class EventModel
    {
        public void SaveEvent(EventDetails eventDetails)
        {
            Event eventData = new Event();
            eventData.OccurrenceType = eventDetails.OccurrenceType;
            eventData.StartDate = eventDetails.StartDate;
            eventData.AdditionalRecurring = eventDetails.AdditionalRecurring;
            eventData.Description = eventDetails.Description;
            eventData.EventType = eventDetails.EventType;

            MyDatabaseFileEntities db = new MyDatabaseFileEntities();

            db.Events.Add(eventData);
            db.SaveChanges();

        }

        public void EditEvent(EventDetails eventDetails)
        {

            MyDatabaseFileEntities db = new MyDatabaseFileEntities();

            Event eventData = db.Events.Find(eventDetails.Id);
            eventData.OccurrenceType = eventDetails.OccurrenceType;
            eventData.StartDate = eventDetails.StartDate;
            eventData.AdditionalRecurring = eventDetails.AdditionalRecurring;
            eventData.Description = eventDetails.Description;
            eventData.EventType = eventDetails.EventType;

            db.SaveChanges();

        }

        public dynamic GetEvent()
        {
            MyDatabaseFileEntities db = new MyDatabaseFileEntities();

            return db.Events;
        }

        public void DeleteEvent(int id)
        {

            MyDatabaseFileEntities db = new MyDatabaseFileEntities();

            Event eventData = db.Events.Find(id);
            db.Events.Remove(eventData);
            db.SaveChanges();

        }


    }


}

