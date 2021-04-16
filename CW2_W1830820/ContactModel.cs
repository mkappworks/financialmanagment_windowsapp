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
       // public MyDatabaseFileEntities DBContact { get; set; }

        public void SaveContact(int type, String name)
        {
            Contact contact = new Contact();

            contact.Type = type;
            contact.Name = name;

            MyDatabaseFileEntities db = new MyDatabaseFileEntities();

            db.Contacts.Add(contact);
            db.SaveChanges();
        }


       // private DBManager dbManager = new DBManager();

        public DataTable GetContact()
        {

            DataTable dt = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["MyDatabaseFileEntities"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Contacts", con))
                {
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dt.Load(reader);
                }
            }

            return dt;

            /*
            //this.DBContact = new MyDatabaseFileEntities();
            MyDatabaseFileEntities db = new MyDatabaseFileEntities();
            var query = db.Contacts.Find(1);
          
            DBManager.ContactHeaderRow row = this.dbManager.ContactHeader.NewContactHeaderRow();

            row.Name = query.Name;
            row.Type = query.Type;

            this.dbManager.ContactHeader.AddContactHeaderRow(row);
            this.dbManager.AcceptChanges();

            /*
            foreach (var record in query) {
                row.Name = record.Name;
                row.Type = record.Type;

                this.dbManager.ContactHeader.AddContactHeaderRow(row);
                this.dbManager.AcceptChanges();
            }
            */



        }
    }
}
