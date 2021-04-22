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
    public partial class ViewTransactionForm : Form
    {
        public TransactionDetails TransactionDetailsData { get; set; }

        public ViewTransactionForm()
        {
            InitializeComponent();
        }



        private void ViewTransactionForm_Load(object sender, EventArgs e)
        {
            GetTransactionData();
        }

        private void GetTransactionData()
        {
            this.dataGridViewTransaction.Rows.Clear();

            TransactionModel transactionModel = new TransactionModel();
            var transactionTable = transactionModel.GetTransaction();

            ContactModel contactModel = new ContactModel();
            var contactTable = contactModel.GetContact();

            foreach (var transaction in transactionTable)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewTransaction.Columns[e.ColumnIndex].Name == "Edit")
            {

                int selectId = (int)dataGridViewTransaction.Rows[e.RowIndex].Cells[0].Value;
                DateTime selectDate = (DateTime)dataGridViewTransaction.Rows[e.RowIndex].Cells[1].Value;
                String selectType = (string)dataGridViewTransaction.Rows[e.RowIndex].Cells[2].Value;
                String selectName = (string)dataGridViewTransaction.Rows[e.RowIndex].Cells[3].Value;
                double selectAmount = (double)dataGridViewTransaction.Rows[e.RowIndex].Cells[4].Value;


                this.TransactionDetailsData = new TransactionDetails();
                this.TransactionDetailsData.Id = selectId;
                this.TransactionDetailsData.Date = selectDate;
                this.TransactionDetailsData.Type = selectType;
                this.TransactionDetailsData.Amount = selectAmount;


                EditTransactionForm editTransactionForm = new EditTransactionForm(TransactionDetailsData);
                editTransactionForm.Activate();
                editTransactionForm.ShowDialog();


                GetTransactionData();


            }

            if (dataGridViewTransaction.Columns[e.ColumnIndex].Name == "Delete")
            {


                if (MessageBox.Show("Do you want to delete the selected transaction?", "PFMS | Delete Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int selectId = (int)dataGridViewTransaction.Rows[e.RowIndex].Cells[0].Value;

                    TransactionModel transactionModel = new TransactionModel();
                    transactionModel.DeleteTransaction(selectId);
 
                    MessageBox.Show("Successfully Deleted");

                    transactionDetailsBindingSource.RemoveCurrent();
                }

            }

        }
    }
}
