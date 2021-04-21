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

        public void SaveContact(int type, String name)
        {
            Contact contact = new Contact();

            contact.Type = type;
            contact.Name = name;

            MyDatabaseFileEntities db = new MyDatabaseFileEntities();

            db.Contacts.Add(contact);
            db.SaveChanges();
        }

        public dynamic GetContact()
        {
            MyDatabaseFileEntities db = new MyDatabaseFileEntities();
            var query = db.Contacts;
            // DataTable dataTable = new DataTable;

            //query.Add(dataTable);
            return query;

        }
    }
}
