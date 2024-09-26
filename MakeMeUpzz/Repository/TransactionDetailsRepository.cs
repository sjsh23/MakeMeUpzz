using MakeMeUpzz.Factory;
using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace MakeMeUpzz.Repository
{
    public class TransactionDetailsRepository
    {
        Database1Entities db = DatabaseSingleton.getinstance();
        public void inserttd(int tid, List<Cart> cart)
        {
            foreach(Cart c in cart)
            {
                TransactionDetail td = TransactionFactory.createTransactionDetail(tid, c.MakeupID, c.Quantity);
                db.TransactionDetails.Add(td);
            }
            db.SaveChanges();
        }

        public List<TransactionDetail> FindByTransactionId(int tid)
        {
            return db.TransactionDetails.Where(t => t.TransactionID == tid).ToList();
        }
        public List<TransactionDetail> FindByUserAndMakeupId(int tid)
        {
            return db.TransactionDetails.Where(t => t.MakeupID == tid).ToList();
        }
        public List<TransactionDetail> getAllTransactionDetails()
        {
            return db.TransactionDetails.ToList();
        }

    }
}
    