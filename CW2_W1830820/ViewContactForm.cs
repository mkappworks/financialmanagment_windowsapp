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
        
            var ContactTable = db.Contacts;

            foreach (var contact in ContactTable)
            {
                          contactDetailsBindingSource.Add(new ContactDetails()
                {
                    Type = contact.Type,
                    Name = contact.Name

                });
                
         
                

            }
            
        
            

        }

        private void dataGridViewContact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if(dataGridViewContact.Columns[e.ColumnIndex].Name == "Edit") { }

            if (dataGridViewContact.Columns[e.ColumnIndex].Name == "Delete") {

                if (MessageBox.Show("Do you want to delete the selected contact?", "PFMS | Delete Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    contactDetailsBindingSource.RemoveCurrent();
            }
        }
    }
}

