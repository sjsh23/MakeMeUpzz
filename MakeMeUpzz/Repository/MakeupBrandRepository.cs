using MakeMeUpzz.Model;
using MakeMeUpzz.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repository
{
    
    public class MakeupBrandRepository
    {
        Database1Entities db = new Database1Entities();
        MakeupBrandFactory mfac = new MakeupBrandFactory();

        public int automateID()
        {
            if (GetMakeupBrands().Count() == 0)
            {
                return 1;
            }
            else
            {
                return getLast().MakeupBrandID + 1;
            }
        }
        public List<MakeupBrand> GetMakeupBrands()
        {
            return (from mb in db.MakeupBrands select mb).ToList();
        }
        public List<MakeupBrand> GetMakeupBrandsSorted()
        {
            return (from mb in db.MakeupBrands select mb).OrderByDescending(x => x.MakeupBrandRating).ToList();
        }

        public MakeupBrand getLast()
        {
            return GetMakeupBrands().LastOrDefault();
        }

        public MakeupBrand GetMakeupBrandByID(int id)
        {
            return (from mb in db.MakeupBrands where mb.MakeupBrandID == id select mb).FirstOrDefault();
        }

        public void insertMakeupBrand(int id, string name, int rating)
        {
            MakeupBrand makeupBrand = mfac.createMakeupBrand(id, name, rating);
            db.MakeupBrands.Add(makeupBrand);
            db.SaveChanges();
        }

        public void updateMakeupBrand(int id, string name, int rating)
        {
            MakeupBrand update = new MakeupBrand();
            update = db.MakeupBrands.Find(id);
            update.MakeupBrandName = name;
            update.MakeupBrandRating = rating;
            db.SaveChanges();
        }

        public void DeleteMakeupBrand(int id)
        {
            MakeupBrand del = db.MakeupBrands.Find(id);
            db.MakeupBrands.Remove(del);
            db.SaveChanges();
        }
    }
}