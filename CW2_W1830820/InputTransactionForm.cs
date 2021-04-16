﻿using System;
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

            this.comboBoxContact.Text = "Sam";

            this.TransactionManager(this.dateTimePicker.Value, typeIndex, this.comboBoxContact.Text , double.Parse( this.textBoxAmount.Text));
        }

        

        private void TransactionManager(DateTime date, int type, String contact, double amount)
        {
            TransactionModel transactionModel = new TransactionModel();
            transactionModel.Date = date;
            transactionModel.Type = type;
            transactionModel.Contact = contact;
            transactionModel.Amount = amount;

            Console.WriteLine(transactionModel.Date);
            Console.WriteLine(transactionModel.Amount);
            Console.WriteLine(transactionModel.Contact);

         this.DBWrite(transactionModel);

        }

        private void DBWrite(TransactionModel transactionModel)
        {
            DBManager.TransactionHeaderRow row = this.dbManager.TransactionHeader.NewTransactionHeaderRow();

            row.Date = transactionModel.Date;
            row.Type = transactionModel.Type;
            row.FK_ContactNo = 1;
            row.Amount = transactionModel.Amount;

            this.dbManager.TransactionHeader.AddTransactionHeaderRow(row);
            this.dbManager.AcceptChanges();

            this.dbManager.WriteXml(@"data.xml");

            Console.WriteLine(row.Amount);
            Console.WriteLine(row);

           // this.dbManager.ReadXml(@"data.xml");

            this.Close();

        }
  
    }
}
