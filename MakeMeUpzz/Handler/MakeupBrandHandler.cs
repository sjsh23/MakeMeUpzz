using MakeMeUpzz.Model;
using MakeMeUpzz.Factory;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations.Model;

namespace MakeMeUpzz.Handler
{
    public class MakeupBrandHandler
    {
        public static List<MakeupBrand> GetMakeupBrands()
        {
            MakeupBrandRepository repo = new MakeupBrandRepository();
            return repo.GetMakeupBrandsSorted();
        }

        public static MakeupBrand GetMakeupBrandByID(int id)
        {
            MakeupBrandRepository repo = new MakeupBrandRepository();
            return repo.GetMakeupBrandByID(id);
        }

        public static string insertMakeupBrand(string name, int rating)
        {
            MakeupBrandRepository repo = new MakeupBrandRepository();
            repo.insertMakeupBrand(repo.automateID(), name, rating);
            return "success";
        }

        public static string updateMakeupBrand(int id, string name, int rating)
        {
            MakeupBrandRepository repo = new MakeupBrandRepository();
            repo.updateMakeupBrand(id, name, rating);
            return "success";
        }
        public static void deleteMakeupBrand(int id)
        {
            MakeupBrandRepository brepo = new MakeupBrandRepository();
            MakeupRepository mrepo = new MakeupRepository();

            mrepo.DeleteMakeupByBrandID(id);
            brepo.DeleteMakeupBrand(id);
        }
    }
}