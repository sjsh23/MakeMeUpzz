using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using MakeMeUpzz.Factory;
using System.Web.Management;

namespace MakeMeUpzz.Handler
{
    public class MakeupHandler
    {
        public static List<Makeup> GetMakeups()
        {
            MakeupRepository repo = new MakeupRepository();
            return repo.getMakeups();
        }

        public static Makeup GetMakeupByID(int id)
        {
            MakeupRepository repo = new MakeupRepository();
            return repo.getMakeupByID(id);
        }

        public static string insertMakeup(string name, int price, int weight, int makeupTypeid, int makeupBrandid)
        {
            MakeupRepository repo = new MakeupRepository();
            repo.insertMakeup(repo.automateID(), name, price, weight, makeupTypeid, makeupBrandid);
            return "success";
        }

        public static string updateMakeup(int id, string name, int price, int weight, int makeupTypeid, int makeupBrandid)
        {
            MakeupRepository repo = new MakeupRepository();
            repo.UpdateMakeup(id, name, price, weight, makeupTypeid, makeupBrandid);
            return "success";
        }

        public static void deleteMakeup(int id)
        {
            MakeupRepository repo = new MakeupRepository();
            repo.DeleteMakeup(id);
            return;
        }
    }
}