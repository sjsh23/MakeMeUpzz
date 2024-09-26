using MakeMeUpzz.Handler;
using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class TransactionHeaderController
    {
        TransactionHeaderHandler th = new TransactionHeaderHandler();
        public List<TransactionHeader> getAllTransactionHeaders()
        {
            return th.getAllTransactionHeaders();
        }
        public List<TransactionHeader> getbyuserid(int id)
        {
            return th.getbyuserid(id);

        }
        public List<TransactionHeader> getunhandledtransaction()
        {
            return th.getunhandledtransaction();
        }
        public TransactionHeader search(int tid)
        {
            return th.search(tid);
        }
        public string handleTransaction(int TransactionID)
        {
            return th.handleTransaction(TransactionID);
            
        }
        public TransactionHeader GetLastTransaction()
        {
            return th.GetLastTransaction();
        }

        public int generateTransactionID()
        {
            return TransactionHeaderHandler.generateTransactionID();
        }

        public string InsertNewUnhandledTransaction(int id, int uid, List<Cart> insert)
        {

            return th.InsertNewUnhandledTransaction(id, uid, insert);
        }
    }
}