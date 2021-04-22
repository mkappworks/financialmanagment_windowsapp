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
    public partial class EditContactForm : Form
    {

        public ContactDetails ContactDetailsData { get; set; }
     
        private DBManager dbManager = new DBManager();


        public EditContactForm(int id, string type, string name)
        {
            InitializeComponent();

            this.ContactDetailsData = new ContactDetails();

            ContactDetailsData.Id = id;
            ContactDetailsData.Type = type;
            ContactDetailsData.Name = name;

            if (ContactDetailsData.Type == "Payer")
            {
                this.radioBtnPayer.Checked = true;
            }
            else if (ContactDetailsData.Type == "Payee")
            {
                this.radioBtnPayee.Checked = true;
            }

            this.textName.Text = ContactDetailsData.Name;

        }



        private void EditContact(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to edit the selected contact?", "PFMS | Edit Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.ContactDetailsData.Name = textName.Text;

                if (File.Exists(@"contacteditdata.xml"))
                {
                    this.dbManager.ReadXml(@"contacteditdata.xml");
                }


                DBManager.ContactHeaderRow row = this.dbManager.ContactHeader.NewContactHeaderRow(); ;


                row.Name = this.ContactDetailsData.Name;
                row.Type = this.ContactDetailsData.Type;

                this.dbManager.ContactHeader.AddContactHeaderRow(row);
                this.dbManager.AcceptChanges();

                this.dbManager.WriteXml(@"contacteditdata.xml");


                ContactModel contactModel = new ContactModel();
                
            
                contactModel.EditContact(this.ContactDetailsData.Id, this.ContactDetailsData.Name);

                this.dbManager.Reset();
                File.Delete(@"contacteditdata.xml");

                MessageBox.Show("Successfully Edited");

                this.Close();

            }

        }
    }

}
