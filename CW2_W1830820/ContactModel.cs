﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    }
}
