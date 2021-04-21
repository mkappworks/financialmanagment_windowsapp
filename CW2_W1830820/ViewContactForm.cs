using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CW2_W1830820
{
    public partial class ViewContactForm : Form
    {
        public ViewContactForm()
        {
            InitializeComponent();
            
        }

      

        private void ViewContactLoad(object sender, EventArgs e)
        {
         
      

            MyDatabaseFileEntities db = new MyDatabaseFileEntities();
            List listContacts = new List();
            ContactDetails contactDetails = new ContactDetails();

            var ContactTable = db.Contacts;

            foreach (var contact in ContactTable)
            {
                //this.dataGridViewContact.Rows.Add(contact.Name, contact.Type);
                listContacts.Add(contactDetails.Name = contact.Name, contactDetails.Type = contact.Type);

            }


           
          


        }
    }
}

