using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repository
{
    public class DatabaseSingleton
    {
        private static Database1Entities db = null;
        public static Database1Entities getinstance()
        {
            if (db == null)
            {
                db = new Database1Entities();   
            }
            return db;
        }

    }
}