using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace CW2_W1830820
{
    public partial class ViewContactForm : Form
    {
        public ContactDetails ContactDetailsData { get; set; }
        private DBManager dbManager = new DBManager();

        public ViewContactForm()
        {
            InitializeComponent();

        }

        private void ViewContactLoad(object sender, EventArgs e)
        {
            GetContactData();

        }

        private void GetContactData()
        {
            this.dataGridViewContact.Rows.Clear();

            ContactModel contactModel = new ContactModel();
            var ContactTable = contactModel.GetContact();

            foreach (var contact in ContactTable)
            {
                this.contactDetailsBindingSource.Add(new ContactDetails()
                {
                    Id = contact.Id,
                    Type = contact.Type,
                    Name = contact.Name

                });
            }
        }

        private void dataGridViewContact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridViewContact.Columns[e.ColumnIndex].Name == "Edit")
            {

                int selectId = (int)dataGridViewContact.Rows[e.RowIndex].Cells[0].Value;
                String selectType = (string)dataGridViewContact.Rows[e.RowIndex].Cells[1].Value;
                String selectName = (string)dataGridViewContact.Rows[e.RowIndex].Cells[2].Value;

          
                this.ContactDetailsData = new ContactDetails();
                this.ContactDetailsData.Id = selectId;
                this.ContactDetailsData.Type = selectType;
                this.ContactDetailsData.Name = selectName;

                         
                EditContactForm editContactForm = new EditContactForm(ContactDetailsData.Id , ContactDetailsData.Type, ContactDetailsData.Name);
                editContactForm.Activate();
                editContactForm.ShowDialog();

                GetContactData();


            }

            if (dataGridViewContact.Columns[e.ColumnIndex].Name == "Delete")
            {


                if (MessageBox.Show("Do you want to delete the selected contact?", "PFMS | Delete Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int selectId = (int)dataGridViewContact.Rows[e.RowIndex].Cells[0].Value;

                    ContactModel contactModel = new ContactModel();
                    contactModel.DeleteContact(selectId);

                    MessageBox.Show("Successfully Deleted");

                    contactDetailsBindingSource.RemoveCurrent();
                }

            }
        }
    }
}

