using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;
using System.Data.SqlClient;

namespace CW2_W1830820
{
    class ContactModel
    {

        public void SaveContact(ContactDetails contactDetails)
        {
            Contact contact = new Contact();

            contact.Type = contactDetails.Type;

            contact.Name = contactDetails.Name;

            MyDatabaseFileEntities db = new MyDatabaseFileEntities();

            db.Contacts.Add(contact);
            db.SaveChanges();
        }

        public dynamic GetContact()
        {
            MyDatabaseFileEntities db = new MyDatabaseFileEntities();

            return db.Contacts;
        }

        public void EditContact(int id , String name) {
           
            MyDatabaseFileEntities db = new MyDatabaseFileEntities();

            Contact contact = db.Contacts.Find(id);
            contact.Name = name;
            db.SaveChanges();
        }

        public void DeleteContact(int id) {
                     
            MyDatabaseFileEntities db = new MyDatabaseFileEntities();

            Contact contact = db.Contacts.Find(id);
            db.Contacts.Remove(contact);
            db.SaveChanges();
        }
    }
}
