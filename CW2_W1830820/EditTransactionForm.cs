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
    public partial class EditTransactionForm : Form
    {
        public EditTransactionForm()
        {
            InitializeComponent();
           TransactionDetails transactionModel = new TransactionDetails();

            if (transactionModel.Type == 1)
            {
                this.radioBtnExpense.Checked = true;
            }
            else if (transactionModel.Type == 2)
            {
                this.radioBtnIncome.Checked = true;
            }


            this.dateTimePicker.Value = transactionModel.Date;
            this.comboBoxContact.Text = transactionModel.Contact;
            this.textBoxAmount.Text = transactionModel.Amount.ToString();
        }

        private void EditTransaction(object sender, EventArgs e)
        {

            int typeIndex = 1;

            if (this.radioBtnExpense.Checked == true)
            {
                typeIndex = 1;
            }
            else if (this.radioBtnIncome.Checked == true)
            {
                typeIndex = 2;
            }

            this.TransactionManager(this.dateTimePicker.Value, typeIndex, this.comboBoxContact.Text, double.Parse(this.textBoxAmount.Text));
        }


        private void TransactionManager(DateTime date, int type, String contact, double amount)
        {
            TransactionDetails transactionModel = new TransactionDetails();
            transactionModel.Date = date;
            transactionModel.Type = type;
            transactionModel.Contact = contact;
            transactionModel.Amount = amount;

        }
    }
}
