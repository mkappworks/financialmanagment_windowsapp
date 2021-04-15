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
    public partial class InputContactForm : Form
    {

       

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
