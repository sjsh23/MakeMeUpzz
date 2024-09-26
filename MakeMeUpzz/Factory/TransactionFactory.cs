using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using MakeMeUpzz.Model;

namespace MakeMeUpzz.Factory
{
    public class TransactionFactory
    {
        public static TransactionHeader createTransactionHeader(int id, int userid, string status)
        {
            TransactionHeader transactionHeader = new TransactionHeader();
            transactionHeader.TransactionID = id;
            transactionHeader.UserID = userid;
            transactionHeader.TransactionDate = DateTime.UtcNow;
            transactionHeader.Status = status;

            return transactionHeader;
        }

        public static TransactionDetail createTransactionDetail(int id, int makeupid, int quantity)
        {
            TransactionDetail transactionDetail = new TransactionDetail();
            transactionDetail.TransactionID = id;
            transactionDetail.MakeupID = makeupid;
            transactionDetail.Quantity = quantity;

            return transactionDetail;
        }
    }
}