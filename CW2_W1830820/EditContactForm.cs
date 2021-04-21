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
    public partial class EditContactForm : Form
    {
        public EditContactForm()
        {
            InitializeComponent();
            ContactDetails contactModel = new ContactDetails();



            if (contactModel.Type == "Payer")
            {
                this.radioBtnPayer.Checked = true;
            }
            else if (contactModel.Type == "Payee")

            {
                this.radioBtnPayee.Checked = true;
            }


            this.textName.Text = contactModel.Name;
       

        }

        private void EditContact(object sender, EventArgs e)
        {

            String type = radioBtnPayer.Text;

            if (this.radioBtnPayer.Checked == true)
            {
                type = radioBtnPayer.Text;
            }
            else if (this.radioBtnPayee.Checked == true)
            {
                type = radioBtnPayer.Text;
            }

          

            this.ContactManager(type, this.textName.Text);
        }


        private void ContactManager(String type, String name)
        {
            ContactDetails contactModel = new ContactDetails();
            contactModel.Name = name;
            contactModel.Type = type;
        }
    }
        
    }
