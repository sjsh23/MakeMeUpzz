using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MakeMeUpzz.Handler;
using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;

namespace MakeMeUpzz.Controller
{
    public class MakeupController
    {
        public static List<Makeup> GetMakeups()
        {
            return MakeupHandler.GetMakeups();
        }

        public static Makeup GetMakeupByID(int id)
        {
            return MakeupHandler.GetMakeupByID(id); 
        }

        public static string insertMakeup( string name, int price, int weight, int makeupTypeid, int makeupBrandid, bool priceIsEmpty, bool weightIsEmpty)
        {
            if (name == null || name.Length == 0)
            {
                return "please input name";
            }
            else if (name.Length < 1 || name.Length > 99)
            {
                return "name must be between 1 and 99 characters long";
            }
            else if (priceIsEmpty == true)
            {
                return "please input price";
            }
            else if (price < 1)
            {
                return "price must be greater than 1";
            }
            else if (weightIsEmpty == true)
            {
                return "please input weight";
            }
            else if (weight < 1 || weight > 1500)
            {
                return "weight must be between 1 and 1500 grams";
            }

            else if (makeupTypeid == default)
            {
                return "please choose a Type";
            }
            else if (makeupBrandid == default)
            {
                return "please choose a Brand";
            }
            else
            {
                return MakeupHandler.insertMakeup(name, price, weight, makeupTypeid, makeupBrandid);
            }
        }

        public static string updateMakeup(int id, string name, int price, int weight, int makeupTypeid, int makeupBrandid, bool priceIsEmpty, bool weightIsEmpty)
        {
            if (name == null || name.Length == 0)
            {
                return "please input name";
            }
            else if (name.Length < 1 || name.Length > 99)
            {
                return "name must be between 1 and 99 characters long";
            }
            else if (priceIsEmpty == true)
            {
                return "please input price";
            }
            else if (price < 1)
            {
                return "price must be greater than 1";
            }
            else if (weightIsEmpty == true)
            {
                return "please input weight";
            }
            else if (weight < 1 || weight > 1500)
            {
                return "weight must be between 1 and 1500 grams";
            }

            else if (makeupTypeid == default)
            {
                return "please choose a Type";
            }
            else if (makeupBrandid == default)
            {
                return "please choose a Brand";
            }
            else
            {
                return MakeupHandler.updateMakeup(id, name, price, weight, makeupTypeid, makeupBrandid);
            }
        }
        public static void deleteMakeup(int id)
        {
            MakeupHandler.deleteMakeup(id);
            return;
        }
    }
        
}