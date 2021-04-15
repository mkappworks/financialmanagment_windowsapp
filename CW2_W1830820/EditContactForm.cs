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
            ContactModel contactModel = new ContactModel();

            if (contactModel.Type == 1)
            {
                this.radioBtnPayer.Checked = true;
            }
            else if (contactModel.Type == 2)
            {
                this.radioBtnPayee.Checked = true;
            }


            this.textName.Text = contactModel.Name;
       

        }

        private void EditContact(object sender, EventArgs e)
        {

            int typeIndex = 1;

            if (this.radioBtnPayer.Checked == true)
            {
                typeIndex = 1;
            }
            else if (this.radioBtnPayee.Checked == true)
            {
                typeIndex = 2;
            }

            this.ContactManager(typeIndex, this.textName.Text);
        }


        private void ContactManager(int type, String name)
        {
            ContactModel contactModel = new ContactModel();
            contactModel.Name = name;
            contactModel.Type = type;
        }
    }
        
    }
