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
            getData();

        }

        private void getData()
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

                EditContactForm editContactForm = new EditContactForm(selectId, selectType, selectName);
                editContactForm.Activate();
                editContactForm.ShowDialog();

                getData();


            }

            if (dataGridViewContact.Columns[e.ColumnIndex].Name == "Delete")
            {


                if (MessageBox.Show("Do you want to delete the selected contact?", "PFMS | Delete Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int selectId = (int)dataGridViewContact.Rows[e.RowIndex].Cells[0].Value;

                    ContactModel contactModel = new ContactModel();
                    contactModel.DeleteContact(selectId);

                    contactDetailsBindingSource.RemoveCurrent();
                }

            }
        }
    }
}

