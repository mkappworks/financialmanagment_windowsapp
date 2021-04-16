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

//using MySql.Data.MySqlClient;

namespace CW2_W1830820
{
    public partial class InputContactForm : Form
    {

        XmlSerializer xs;
        List<ContactModel> ls;

        public InputContactForm()
        {
            InitializeComponent();
            this.radioBtnPayer.Checked = true;

            ls = new List<ContactModel>();
            xs = new XmlSerializer(typeof(List<ContactModel>));

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
            String workingDir = Directory.GetCurrentDirectory();

           // Console.WriteLine(workingDir + "\ncontact.Xml");

       

                  FileStream fs = new FileStream("G:\\contact.Xml", FileMode.Create, FileAccess.Write);

         //   FileStream fs = new FileStream(workingDir + "\ncontact.Xml", FileMode.Create, FileAccess.Write);

            ContactModel contactModel = new ContactModel();
            contactModel.Name = name;
            contactModel.Type = type;

            ls.Add(contactModel);
            xs.Serialize(fs, ls);
            fs.Close();
        }
         
    }
}
