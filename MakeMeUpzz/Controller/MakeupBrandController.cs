using MakeMeUpzz.Handler;
using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class MakeupBrandController
    {
        public static List<MakeupBrand> GetMakeupBrands()
        {
            return MakeupBrandHandler.GetMakeupBrands();
        }

        public static MakeupBrand GetMakeupBrandByID(int id)
        {
            return MakeupBrandHandler.GetMakeupBrandByID(id);
        }

        public static string insertMakeupBrand(string name, int rating, bool ratingIsEmpty)
        {
            if(name == null || name.Length == 0)
            {
                return "please input name";
            }
            else if(name.Length < 1 || name.Length > 99)
            {
                return "name must be between 1 and 99 characters";
            }
            else if (ratingIsEmpty)
            {
                return "please input rating";
            }
            else if(rating < 0 || rating > 100)
            {
                return "rating must be between 0 - 100";
            }
            else
            {
                return MakeupBrandHandler.insertMakeupBrand(name, rating);
            }
        }

        public static string updateMakeupBrand(int id, string name, int rating, bool ratingIsEmpty)
        {
            if (name == null || name.Length == 0)
            {
                return "please input name";
            }
            else if (name.Length < 1 || name.Length > 99)
            {
                return "name must be between 1 and 99 characters";
            }
            else if (ratingIsEmpty)
            {
                return "please input rating";
            }
            else if (rating < 0 || rating > 100)
            {
                return "rating must be between 0 - 100";
            }
            else
            {
                return MakeupBrandHandler.updateMakeupBrand(id ,name, rating);
            }
        }

        public static void deleteMakeupBrand(int id)
        {
            MakeupBrandHandler.deleteMakeupBrand(id);
            return;
        }
    }
}