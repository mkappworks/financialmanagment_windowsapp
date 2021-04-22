using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2_W1830820
{
    class TransactionModel
    {

        public void SaveTransaction(TransactionDetails transactionDetails)
        {
            Transaction transaction = new Transaction();
            transaction.Date = transactionDetails.Date;
            transaction.Type = transactionDetails.Type;
            transaction.ContactId = transactionDetails.ContactId;
            transaction.Amount = transactionDetails.Amount;

            MyDatabaseFileEntities db = new MyDatabaseFileEntities();

            db.Transactions.Add(transaction);
            db.SaveChanges();
        }

        public dynamic GetTransaction()
        {
            MyDatabaseFileEntities db = new MyDatabaseFileEntities();

            return db.Transactions;
        }

        public void EditTransaction(TransactionDetails transactionDetails)
        {

            MyDatabaseFileEntities db = new MyDatabaseFileEntities();

            Transaction transaction = db.Transactions.Find(transactionDetails.Id);
            transaction.Date = transactionDetails.Date;
            transaction.ContactId = transactionDetails.ContactId;
            transaction.Amount = transactionDetails.Amount;

            db.SaveChanges();
        }

        public void DeleteTransaction(int id)
        {
            MyDatabaseFileEntities db = new MyDatabaseFileEntities();

            Transaction transaction = db.Transactions.Find(id);
            db.Transactions.Remove(transaction);
            db.SaveChanges();
        }
    }

}
