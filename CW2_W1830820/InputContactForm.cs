using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace CW2_W1830820
{
    public partial class InputContactForm : Form

    {
        private DBManager dbManager = new DBManager();
        public ContactDetails ContactDetailsData { get; set; }
        

        public InputContactForm()
        {
            InitializeComponent();

            this.radioBtnPayer.Checked = true;


        }

        private void SaveContact(object sender, EventArgs e)

        {

            if (MessageBox.Show("Do you want to save the new contact?", "PFMS | Save Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String type = radioBtnPayer.Text;

                if (this.radioBtnPayer.Checked == true)
                {
                    type = radioBtnPayer.Text;
                }
                else if (this.radioBtnPayee.Checked == true)
                {
                    type = radioBtnPayee.Text;
                }

                this.ContactDetailsData = new ContactDetails();
                this.ContactDetailsData.Type = type;
                this.ContactDetailsData.Name = this.textName.Text;

                if (File.Exists(@"contactinputdata.xml"))
                {
                    this.dbManager.ReadXml(@"contactinputdata.xml");
                }


                DBManager.ContactHeaderRow row = this.dbManager.ContactHeader.NewContactHeaderRow(); ;

                row.Name = this.ContactDetailsData.Name;
                row.Type = this.ContactDetailsData.Type;

                this.dbManager.ContactHeader.AddContactHeaderRow(row);
                this.dbManager.AcceptChanges();

                this.dbManager.WriteXml(@"contactinputdata.xml");

                ContactModel contactModel = new ContactModel();
                contactModel.SaveContact(this.ContactDetailsData);

                this.dbManager.Reset();
                File.Delete(@"contactinputdata.xml");

                MessageBox.Show("Successfully Saved");

                this.radioBtnPayer.Checked = true;
                this.textName.Clear();
            }


        }

    }
}
