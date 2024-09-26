using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class TransactionHeaderHandler
    {
        private readonly TransactionRepository trepo;

        public TransactionHeaderHandler()
        {
            trepo = new TransactionRepository();
        }

        public string InsertNewUnhandledTransaction(int id, int uid, List<Cart> insert )
        {
            CartRepository crepo = new CartRepository();
            TransactionRepository trepo = new TransactionRepository();
            TransactionDetailsRepository tdrepo = new TransactionDetailsRepository();
            
            trepo.insertTransactionHeader(id, uid, "unhandled");
            tdrepo.inserttd(id, insert);
            crepo.DeleteCartByUserID(uid);
            return "success";
        }

        public TransactionHeader GetLastTransaction()
        {
            TransactionRepository trepo = new TransactionRepository();
            return trepo.getlasttransaction();
        }
        public List<TransactionHeader> getbyuserid(int id)
        {
            return trepo.GetTransactionHeadersByUserID(id);

        }
        public List<TransactionHeader> getAllTransactionHeaders()
        {
            return trepo.GetTransactionHeaders();
        }
        public List<TransactionHeader> getunhandledtransaction()
        {
            return trepo.getUnhandledTransaction();
        }
        public TransactionHeader search(int tid)
        {
            return trepo.search(tid);
        }
        public string handleTransaction(int TransactionID)
        {
            trepo.updateStatusbyID(TransactionID, "handled");
            return "success";
        }

        public List<TransactionHeader> getallTransaction()
        {
            return trepo.getallTransactions();
        }

        public static int generateTransactionID()
        {
            TransactionRepository trepo = new TransactionRepository();
            return trepo.generatetransactionid();
        }
    }
}