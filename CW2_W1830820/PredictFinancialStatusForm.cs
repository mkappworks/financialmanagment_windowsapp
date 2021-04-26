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
    public partial class PredictFinancialStatusForm : Form
    {
        public PredictFinancialStatusForm()
        {
            InitializeComponent();
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            GetTransactionData();
        }

        private void GetTransactionData()
        {
            TransactionModel transactionModel = new TransactionModel();
            var transactionTable = transactionModel.GetTransaction();
            List<TransactionDetails> filteredTransactionList = new List<TransactionDetails>();

            DateTime currentDate = DateTime.UtcNow.Date;
            DateTime futureDate = dateTimePickerDate.Value.Date;

            double totalFutureDays = (futureDate - currentDate).TotalDays;
            DateTime pastDate = currentDate.AddDays(-totalFutureDays);

            //Create a List of transactions from the pastDate to currentDate
            foreach (var transaction in transactionTable)
            {
                if (transaction.Date.Date >= pastDate)
                {
                    filteredTransactionList.Add(new TransactionDetails()
                    {
                        Id = transaction.Id,
                        Date = transaction.Date,
                        Type = transaction.Type,
                        Amount = transaction.Amount
                    });
                }
            }

            //Sort the  filteredTransactionList by Date in ascending order 
            List<TransactionDetails> sortedTransactionList = filteredTransactionList.OrderBy(record => record.Date).ToList();

            //Get list of Dates repeating in sortedTransactionList
            List<DateTime> sortedTransactionDateTimeList = new List<DateTime>();

            foreach (var record in sortedTransactionList)
            {
                if (!sortedTransactionDateTimeList.Contains(record.Date.Date))
                {
                    sortedTransactionDateTimeList.Add(record.Date.Date);
                }
            }

            //Get a list with NetAmount per a given date in the sortedTransactionDateTimeList to  combinedTransactionList

            DateTime minDateFromSortedTransactionList = sortedTransactionDateTimeList[0];
            DateTime currentLoopDate = minDateFromSortedTransactionList;
            double netAmountPerDate = 0;
            int sortedTransactionDateTimeListIndex = 0;

            List<TransactionDetails> combinedTransactionList = new List<TransactionDetails>();

            foreach (var record in sortedTransactionList)
            {

                if (record.Date != currentLoopDate)
                {
                    combinedTransactionList.Add(new TransactionDetails()
                    {
                        Date = currentLoopDate,
                        Amount = netAmountPerDate,
                    });

                    currentLoopDate = sortedTransactionDateTimeList[sortedTransactionDateTimeListIndex++];
                    netAmountPerDate = 0;
                }

                double transactionAmount = 0;
                if (record.Type == "Income")
                {
                    transactionAmount = record.Amount;
                }
                else
                {
                    transactionAmount = -1 * record.Amount;
                }

                netAmountPerDate += transactionAmount;

                if (record == sortedTransactionList.Last())
                {
                    combinedTransactionList.Add(new TransactionDetails()
                    {
                        Date = currentLoopDate,
                        Amount = netAmountPerDate,
                    });
                }
            }

            //Get a list with day and netAmount per a given date in the combinedTransactionList to updateCombinedTransactionList
            List<dynamic> updateCombinedTransactionList = new List<dynamic>();
            double currentDay = 1;

            for (int i = 0; i < combinedTransactionList.Count; i++)
            {
                List<dynamic> currentItemList = new List<dynamic>();
                currentItemList.Add(currentDay);
                currentItemList.Add(combinedTransactionList[0].Amount);

                updateCombinedTransactionList.Add(currentItemList);

                if (i != combinedTransactionList.Count - 1)
                {
                    currentDay = (combinedTransactionList[i + 1].Date - combinedTransactionList[i].Date).TotalDays + currentDay;
                }

            }

            //Calculate the slope and y-intercept of the Line of Best Fit (Least Square Method) of the datavalues in  updateCombinedTransactionList

            //Calculate the mean of days and netAmount

            double meanDays = 0;
            double meanNetAmount = 0;
            double totalDays = 0;
            double totalNetAmount = 0;
            double numberofItemsInUpdateCombinedTransactionList = updateCombinedTransactionList.Count;

            foreach (var item in updateCombinedTransactionList)
            {
                totalDays += item[0];
                totalNetAmount += item[1];
            }

            meanDays = totalDays / numberofItemsInUpdateCombinedTransactionList;
            meanNetAmount = totalNetAmount / numberofItemsInUpdateCombinedTransactionList;

            //Calculate the slope
            double slopeNumerator = 0;
            double slopeDenominator = 0;

            foreach(var item in updateCombinedTransactionList)
            {

            }


        }

    }
}

