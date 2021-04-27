using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.OleDb;
using System.IO;

namespace CW2_W1830820
{
    public partial class InputTransactionForm : Form
    {

        private DBManager dbManager = new DBManager();
        private TransactionDetails TransactionDetailsData { get; set; }

        private List<ContactDetails> listOfPayer = new List<ContactDetails>();

        private List<ContactDetails> listOfPayee = new List<ContactDetails>();

        private int currentSelectedContactId;

        public InputTransactionForm()
        {
            InitializeComponent();
            GetContactData();

        }

        private void GetContactData()
        {

            ContactModel contactModel = new ContactModel();
            var contactTable = contactModel.GetContact();

            foreach (var record in contactTable)
            {
                if (record.Type == "Payee")
                {
                    this.listOfPayee.Add(new ContactDetails()
                    {
                        Id = record.Id,
                        Type = record.Type,
                        Name = record.Name

                    });
                    //Initially, the Expense is selected
                    this.comboBoxContact.Items.Add(record.Name);
                }
                else
                {
                    this.listOfPayer.Add(new ContactDetails()
                    {
                        Id = record.Id,
                        Type = record.Type,
                        Name = record.Name

                    });
                }
            }


        }

        private void radioBtnExpense_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxContact.Items.Clear();
            if (this.radioBtnExpense.Checked == true)
            {
                foreach (var item in listOfPayee)
                {
                    this.comboBoxContact.Items.Add(item.Name);
                }
            }

        }

        private void radioBtnIncome_CheckedChanged(object sender, EventArgs e)
        {

            comboBoxContact.Items.Clear();

            if (this.radioBtnIncome.Checked == true)
            {
                foreach (var item in listOfPayer)
                {
                    this.comboBoxContact.Items.Add(item.Name);
                }
            }

        }
        private void SaveTransaction(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to save the new transaction?", "PFMS | Save Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string type = radioBtnExpense.Text;

                if (this.radioBtnExpense.Checked == true)
                {
                    type = radioBtnExpense.Text;
                }
                else if (this.radioBtnIncome.Checked == true)
                {
                    type = radioBtnIncome.Text;
                }

                this.TransactionDetailsData = new TransactionDetails();
                this.TransactionDetailsData.Date = this.dateTimePicker.Value;
                this.TransactionDetailsData.Type = type;
                this.TransactionDetailsData.ContactId = this.currentSelectedContactId;
                this.TransactionDetailsData.Amount = double.Parse(textBoxAmount.Text);


                if (File.Exists(@"transactioninputdata.xml"))
                {
                    this.dbManager.ReadXml(@"transactioninputdata.xml");
                }

                DBManager.TransactionHeaderRow row = this.dbManager.TransactionHeader.NewTransactionHeaderRow();

                row.Date = this.TransactionDetailsData.Date;
                row.Type = this.TransactionDetailsData.Type;
                row.FK_ContactNo = this.TransactionDetailsData.ContactId;
                row.Amount = this.TransactionDetailsData.Amount;

                this.dbManager.TransactionHeader.AddTransactionHeaderRow(row);
                this.dbManager.AcceptChanges();

                this.dbManager.WriteXml(@"transactioninputdata.xml");

                Eventt transactionModel = new Eventt();
                transactionModel.SaveTransaction(this.TransactionDetailsData);


                this.dbManager.Reset();
                File.Delete(@"transactioninputdata.xml");

                MessageBox.Show("Successfully Saved");

                // this.dateTimePicker.Value = DateTime.UtcNow();
                this.radioBtnExpense.Checked = true;
                this.textBoxAmount.Clear();

            }


        }

       

        private void comboBoxContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            int comboBoxItemIndex = comboBoxContact.SelectedIndex;

            if (this.radioBtnExpense.Checked == true)
            {

                this.currentSelectedContactId = listOfPayee[comboBoxItemIndex].Id;

            }
            else if (this.radioBtnIncome.Checked == true)
            {
                this.currentSelectedContactId = listOfPayer[comboBoxItemIndex].Id;

            }

        }

    }


}






