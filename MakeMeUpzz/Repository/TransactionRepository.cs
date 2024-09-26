using MakeMeUpzz.Model;
using MakeMeUpzz.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MakeMeUpzz.Controller;

namespace MakeMeUpzz.Repository
{
    public class TransactionRepository
    {
        Database1Entities db = new Database1Entities();

        public List<TransactionHeader> GetTransactionHeaders()
        {
            return (from th in db.TransactionHeaders select th).ToList();
        }

        public List<TransactionHeader> GetTransactionHeadersByUserID(int id)
        {
            return (from th in db.TransactionHeaders where th.UserID == id select th).ToList();
        }

        public TransactionHeader GetTransactionHeaderByTransactionID(int id)
        {
            return (from th in db.TransactionHeaders where th.TransactionID == id select th).FirstOrDefault();
        }

        public void insertTransactionHeader(int id, int userid, string status)
        {
            TransactionHeader transactionHeader = TransactionFactory.createTransactionHeader(id, userid, status);
            db.TransactionHeaders.Add(transactionHeader);
            db.SaveChanges();
        }

        public void insertTransactionDetail(int id, int makeupid, int quantity)
        {
            TransactionDetail transactionDetail = TransactionFactory.createTransactionDetail(id, makeupid, quantity);
            db.TransactionDetails.Add(transactionDetail);
            db.SaveChanges();
        }

        public void updateTransactionHeader(int id, string status)
        {
            TransactionHeader update = db.TransactionHeaders.Find(id);
            update.Status = status;
            db.SaveChanges();
        }

        public void deleteTransactionHeader(int id)
        {
            TransactionHeader del = db.TransactionHeaders.Find(id);
            db.TransactionHeaders.Remove(del);
            db.SaveChanges();
        }

        public void deleteTransactionDetail(int id)
        {
            TransactionDetail del = db.TransactionDetails.Find(id);
            db.TransactionDetails.Remove(del);
            db.SaveChanges();
        }
        public TransactionHeader getlasttransaction()
        {
            return db.TransactionHeaders.ToList().LastOrDefault();
        }
        public List<TransactionHeader> getUnhandledTransaction()
        {
            return (from x in db.TransactionHeaders where x.Status == "unhandled" select x).ToList();
        }
        public TransactionHeader search(int tid)
        {
            return (from TransactionHeader in db.TransactionHeaders where TransactionHeader.TransactionID == tid select TransactionHeader).FirstOrDefault();
        }
        public void updateStatusbyID(int TransactionID, string statusnew)
        {
            TransactionHeader th = GetTransactionHeaderByTransactionID(TransactionID);
            th.Status = statusnew;
            db.SaveChanges();
        }
        public List<TransactionHeader> getallTransactions()
        {

            return db.TransactionHeaders.ToList();
        }
        public int generatetransactionid()
        {
            if (getallTransactions().Count == 0)
            {
                return 1;
            }
            else
            {
                return getlasttransaction().UserID + 1;
            }
        }
    }
}