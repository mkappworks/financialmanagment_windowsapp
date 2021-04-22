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

        public TransactionDetails TransactionDetailsData { get; set; }
        private DBManager dbManager = new DBManager();

        public InputTransactionForm()
        {
            InitializeComponent();
          
        }

        private void SaveTransaction(object sender, EventArgs e)
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

  
        }

        

    }
}
