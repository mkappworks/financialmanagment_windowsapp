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
    public partial class GenerateTransactionReportForm : Form
    {
        public TransactionDetails TransactionDetailsData { get; set; }
        public GenerateTransactionReportForm()
        {
            InitializeComponent();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            GetTransactionData();
        }

        private void GetTransactionData()
        {
            this.dataGridViewTransaction.Rows.Clear();

            Eventt transactionModel = new Eventt();
            var transactionTable = transactionModel.GetTransaction();

            ContactModel contactModel = new ContactModel();
            var contactTable = contactModel.GetContact();

            foreach (var transaction in transactionTable)
            {
                if (this.dateTimePickerStartDate.Value.Date <= transaction.Date.Date  && transaction.Date.Date <= this.dateTimePickerEndDate.Value.Date)
                {
                    this.transactionDetailsBindingSource.Add(new TransactionDetails()

                    {
                        Id = transaction.Id,
                        Date = transaction.Date,
                        Type = transaction.Type,
                        ContactId = transaction.ContactId,
                        ContactName = contactTable.Find(transaction.ContactId).Name,
                        Amount = transaction.Amount

                    });
                }


            }
        }
    }
}
