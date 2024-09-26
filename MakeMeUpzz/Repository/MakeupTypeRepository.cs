using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MakeMeUpzz.Model;
using MakeMeUpzz.Factory;

namespace MakeMeUpzz.Repository
{
    public class MakeupTypeRepository
    {
        Database1Entities db = new Database1Entities();
        MakeupTypeFactory mfac = new MakeupTypeFactory();

        public int automateID()
        {
            if (GetMakeupTypes().Count == 0)
            {
                return 1;
            }
            else
            {
                return getLast().MakeupTypeID + 1;
            }

        }
        public List<MakeupType> GetMakeupTypes()
        {
            return (from mt in db.MakeupTypes select mt).ToList();
        }

        public MakeupType getLast()
        {
            return GetMakeupTypes().ToList().LastOrDefault();
        }
        
        public MakeupType GetMakeupTypeById(int id)
        {
            return (from mt in db.MakeupTypes where mt.MakeupTypeID == id select mt).FirstOrDefault();
        }

        public void insertMakeupType(int id, string name)
        {
            MakeupType makeupType = mfac.createMakeupType(id, name);
            db.MakeupTypes.Add(makeupType);
            db.SaveChanges();
        }

        public void updateMakeupType(int id, string name)
        {
            MakeupType update = db.MakeupTypes.Find(id);
            update.MakeupTypeName = name;
            db.SaveChanges();
        }
        public void deleteMakeupType(int id)
        {
            MakeupType del = db.MakeupTypes.Find(id);
            db.MakeupTypes.Remove(del);
            db.SaveChanges();
        }
    }
}