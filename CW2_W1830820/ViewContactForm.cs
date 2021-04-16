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
           // ContactModel contactModel = new ContactModel();
           // contactModel.GetContact();
        }

        private void contactHeaderDataTableBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ViewContactLoad(object sender, EventArgs e)
        {
            ContactModel contactModel = new ContactModel();
            dataGridViewContact.DataSource = contactModel.GetContact();
        }
    }
}
