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
        public ContactDetails ContactDetailsData { get; set; }
        private DBManager dbManager = new DBManager();

        public InputContactForm()
        {
            InitializeComponent();

            this.radioBtnPayer.Checked = true;
        }

        private void SaveContact(object sender, EventArgs e)

        {
            int typeIndex=1;

            if (this.radioBtnPayer.Checked == true) {
                typeIndex = 1;
            }else if(this.radioBtnPayee.Checked == true) {
                typeIndex = 2;
            }

            this.ContactDetailsData = new ContactDetails();
            this.ContactDetailsData.Type = typeIndex;
            this.ContactDetailsData.Name = this.textName.Text;

            if (File.Exists(@"contactdata.xml"))
            {
                this.dbManager.ReadXml(@"contactdata.xml");
            }
             

            DBManager.ContactHeaderRow row = this.dbManager.ContactHeader.NewContactHeaderRow(); ;

            row.Name = this.ContactDetailsData.Name ;
            row.Type = this.ContactDetailsData.Type;

            this.dbManager.ContactHeader.AddContactHeaderRow(row);
            this.dbManager.AcceptChanges();

            this.dbManager.WriteXml(@"contactdata.xml");

            ContactModel contactModel = new ContactModel();
            contactModel.SaveContact(this.ContactDetailsData.Type, this.ContactDetailsData.Name);

            MessageBox.Show("Successfully Saved");

            this.Close();

            //  this.ContactManager(typeIndex, this.textName.Text);
        }
/*
       private void ContactManager(int type, String name)
        {
          
            ContactDetails contactModel = new ContactDetails();
            contactModel.Name = name;
            contactModel.Type = type;

            this.DBWrite(contactModel);


        }


        private void DBWrite(ContactDetails contactModel)
        {
           

        }
*/

    }
}
