using MakeMeUpzz.Handler;
using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class TransactionDetailsController
    {
        public static List<TransactionDetail> getAllTransactionDetails()
        {
            TransactionDetailsHandler transactionDetailHandler = new TransactionDetailsHandler();

            return transactionDetailHandler.getAllTransactionDetails();
        }
        public static List<TransactionDetail> FindByTransactionId(int tid)
        {
            TransactionDetailsHandler transactionDetailHandler = new TransactionDetailsHandler();

            return transactionDetailHandler.FindByTransactionId(tid);
        }
    }
}