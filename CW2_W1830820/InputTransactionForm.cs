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
    public partial class InputTransactionForm : Form
    {
        public InputTransactionForm()
        {
            InitializeComponent();
          
        }

        private void SaveTransaction(object sender, EventArgs e)
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

            this.TransactionManager(this.dateTimePicker.Value, typeIndex, this.comboBoxContact.Text , double.Parse( this.textBoxAmount.Text));

        }

        private void TransactionManager(DateTime date, int type, String contact, double amount)
        {
            TransactionModel transactionModel = new TransactionModel();
            transactionModel.Date = date;
            transactionModel.Type = type;
            transactionModel.Contact = contact;
            transactionModel.Amount = amount;

        }
    }
}
