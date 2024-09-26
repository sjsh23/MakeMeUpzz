using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using MakeMeUpzz.Factory;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repository
{
    public class MakeupRepository
    {
        Database1Entities db = new Database1Entities();
        MakeupTypeRepository mtrep = new MakeupTypeRepository();
        MakeupBrandRepository mbrep = new MakeupBrandRepository();
        MakeupFactory mfac = new MakeupFactory();
        public int automateID()
        {
            if(getMakeups().Count() == 0)
            {
                return 1;
            }
            else
            {
                return getLast().MakeupID + 1;
            }
        }

        public List<Makeup> getMakeups()
        {
            return (from m in db.Makeups select m).ToList();
        }

        public Makeup getMakeupByID(int id)
        {
            return (from m in db.Makeups where m.MakeupID == id select m).FirstOrDefault(); 
        }

        public Makeup getLast()
        {
            return getMakeups().ToList().LastOrDefault();
        }

        public List<Makeup> GetMakeupsByTypeID(int id)
        {
            return (from m in db.Makeups where m.MakeupTypeID == id select m).ToList();
        }

        public List<Makeup> GetMakeupsByBrandID(int id)
        {
            return (from m in db.Makeups where m.MakeupBrandID == id select m).ToList();
        }

        public void insertMakeup(int id, string name, int price, int weight, int makeupTypeid, int makeupBrandid)
        {
            Makeup makeup = mfac.createMakeup(id, name, price, weight, makeupTypeid, makeupBrandid);
            db.Makeups.Add(makeup);
            db.SaveChanges();
        }

        public void DeleteMakeup(int id)
        {
            Makeup del = db.Makeups.Find(id);
            db.Makeups.Remove(del);
            db.SaveChanges();
        }

        public void UpdateMakeup(int id, string name, int price, int weight, int makeupTypeid, int makeupBrandid)
        {
            Makeup update = db.Makeups.Find(id);
            update.MakeupName = name;
            update.MakeupPrice = price;
            update.MakeupWeight = weight;
            update.MakeupTypeID = makeupTypeid;
            update.MakeupBrandID = makeupBrandid;
            db.SaveChanges();
        }

        public void DeleteMakeupByTypeID(int id)
        {
            List<Makeup> del = GetMakeupsByTypeID(id);
            db.Makeups.RemoveRange(del);
            db.SaveChanges();
        }

        public void DeleteMakeupByBrandID(int id)
        {
            List<Makeup> del = GetMakeupsByBrandID(id);
            db.Makeups.RemoveRange(del);
            db.SaveChanges();
        }
    }
}