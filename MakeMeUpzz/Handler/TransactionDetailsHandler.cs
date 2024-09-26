using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class TransactionDetailsHandler
    {
        private readonly TransactionDetailsRepository tdrepo;

        public TransactionDetailsHandler()
        {
            tdrepo = new TransactionDetailsRepository();
        }

        public List<TransactionDetail> getAllTransactionDetails()
        {
            return tdrepo.getAllTransactionDetails();
        }
        public List<TransactionDetail> FindByTransactionId(int tid)
        {
            return tdrepo.FindByTransactionId(tid);
        }
    }
}
    