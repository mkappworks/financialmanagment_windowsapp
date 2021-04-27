using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW2_W1830820
{
    public partial class EditTransactionForm : Form
    {
        private DBManager dbManager = new DBManager();

        public TransactionDetails TransactionDetailsData { get; set; }

        private List<ContactDetails> listOfContact = new List<ContactDetails>();

        private int currentSelectedContactId;

        public EditTransactionForm(TransactionDetails transactionDetails)
        {
            InitializeComponent();

            GetContactData(transactionDetails.Type);

            this.TransactionDetailsData = new TransactionDetails();

            this.TransactionDetailsData.Id = transactionDetails.Id;
            this.TransactionDetailsData.Date = transactionDetails.Date;
            this.TransactionDetailsData.Type = transactionDetails.Type;
            this.TransactionDetailsData.Amount = transactionDetails.Amount;

            this.dateTimePicker.Value = this.TransactionDetailsData.Date;

            if (this.TransactionDetailsData.Type == "Expense")
            {
                this.radioBtnExpense.Checked = true;
            }
            else if (this.TransactionDetailsData.Type == "Income")
            {
                this.radioBtnIncome.Checked = true;
            }



            this.comboBoxContact.Text= this.TransactionDetailsData.ContactName;

            this.textBoxAmount.Text = this.TransactionDetailsData.Amount.ToString();


        }

        private void GetContactData(string type)
        {

            ContactModel contactModel = new ContactModel();
            var contactTable = contactModel.GetContact();

            if (type == "Expense")
            {
                foreach (var record in contactTable) if (record.Type == "Payee")
                    {
                        comboBoxContact.Items.Add(record.Name);
                        this.listOfContact.Add(new ContactDetails()
                        {
                            Id = record.Id,
                            Type = record.Type,
                            Name = record.Name

                        });
                    }
            }
            else
            {
                foreach (var record in contactTable) if (record.Type == "Payer")
                    {
                        comboBoxContact.Items.Add(record.Name);
                        this.listOfContact.Add(new ContactDetails()
                        {
                            Id = record.Id,
                            Type = record.Type,
                            Name = record.Name

                        });
                    }

            }




        }

        private void EditTransaction(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to edit the selected transaction?", "PFMS | Edit Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.TransactionDetailsData.Date = this.dateTimePicker.Value;
                this.TransactionDetailsData.ContactId = this.currentSelectedContactId;
                this.TransactionDetailsData.Amount = double.Parse(this.textBoxAmount.Text);


                if (File.Exists(@"transactioneditdata.xml"))
                {
                    this.dbManager.ReadXml(@"transactioneditdata.xml");
                }


                DBManager.TransactionHeaderRow row = this.dbManager.TransactionHeader.NewTransactionHeaderRow(); ;


                row.Date = this.TransactionDetailsData.Date;
                row.FK_ContactNo = this.TransactionDetailsData.ContactId;
                row.Amount = this.TransactionDetailsData.Amount;



                this.dbManager.TransactionHeader.AddTransactionHeaderRow(row);
                this.dbManager.AcceptChanges();

                this.dbManager.WriteXml(@"transactioneditdata.xml");

                Eventt transactionModel = new Eventt();

                transactionModel.EditTransaction(TransactionDetailsData);



                this.dbManager.Reset();
                File.Delete(@"transactioneditdata.xml");

                MessageBox.Show("Successfully Edited");

                this.Close();

            }
        }

        private void comboBoxContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            int comboBoxItemIndex = comboBoxContact.SelectedIndex;

            this.currentSelectedContactId = listOfContact[comboBoxItemIndex].Id;

        }
    }
}


