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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

   
        private void OpenInputTransactionForm(object sender, EventArgs e)
        { 
            InputTransactionForm inputTransactionForm = new InputTransactionForm();
            inputTransactionForm.Activate();
            inputTransactionForm.ShowDialog();
        }

        private void OpenViewTransactionForm(object sender, EventArgs e)
        {
            ViewTransactionForm viewTransactionForm = new ViewTransactionForm();
            viewTransactionForm.Activate();
            viewTransactionForm.ShowDialog();
        }

        private void OpenInputEventForm(object sender, EventArgs e)
        {
            InputEventForm inputEventForm = new InputEventForm();
            inputEventForm.Activate();
            inputEventForm.ShowDialog();

        }

        private void OpenViewEventForm(object sender, EventArgs e)
        {
            ViewEventForm viewEventForm = new ViewEventForm();
            viewEventForm.Activate();
            viewEventForm.ShowDialog();
        }

        private void OpenInputContactForm(object sender, EventArgs e)
        {
            InputContactForm inputContactForm = new InputContactForm();
            inputContactForm.Activate();
            inputContactForm.ShowDialog();
        }

        private void OpenViewContactForm(object sender, EventArgs e)
        {
            ViewContactForm viewContactForm = new ViewContactForm();
            viewContactForm.Activate();
            viewContactForm.ShowDialog();
        }

        private void OpenPredictFinancialStatusForm(object sender, EventArgs e)
        {
            PredictFinancialStatusForm predictFinancialStatusForm = new PredictFinancialStatusForm();
            predictFinancialStatusForm.Activate();
            predictFinancialStatusForm.ShowDialog();
        }

        private void OpenGenerateTransactionReportForm(object sender, EventArgs e)
        {
            GenerateTransactionReportForm generateTransactionReportForm = new GenerateTransactionReportForm();
            generateTransactionReportForm.Activate();
            generateTransactionReportForm.ShowDialog();
        }

        private void OpenViewWeeklyEventTransactionForm(object sender, EventArgs e)
        {
            ViewWeeklyEventTransactionForm viewWeeklyEventTransactionForm = new ViewWeeklyEventTransactionForm();
            viewWeeklyEventTransactionForm.Activate();
            viewWeeklyEventTransactionForm.ShowDialog();
        }
    }
}
