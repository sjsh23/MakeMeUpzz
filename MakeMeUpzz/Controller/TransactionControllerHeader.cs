using MakeMeUpzz.Handler;
using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class TransactionControllerHeader
    {
        TransactionHeaderHandler th = new TransactionHeaderHandler();
        public List<TransactionHeader> getAllTransactionHeaders()
        {
            return th.getAllTransactionHeaders();
        }
        public void InsertTransactionHeader(int tid, int userid, string status)
        {
            th.InsertTransactionHeader(tid, userid, status);
        }
        public List<TransactionHeader> getbyuserid(int id)
        {
            return th.getbyuserid(id);

        }
        public List<TransactionHeader> getunhandledtransaction(string a)
        {
            return th.getunhandledtransaction(a);
        }
        public TransactionHeader search(int tid)
        {
            return th.search(tid);
        }
        public void updatestatusbyID(int TransactionID, string statusnew)
        {
            th.updatestatusbyID(TransactionID, statusnew);
        }
        public TransactionHeader GetLastTransaction()
        {
            return th.GetLastTransaction();
        }
        public static int generatetransactionid()
        {
            return TransactionHeaderHandler.generatetransactionid();
        }
    }
}