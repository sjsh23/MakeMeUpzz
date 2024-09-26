using MakeMeUpzz.Model;
using MakeMeUpzz.Factory;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class MakeupTypeHandler
    {
        public static List<MakeupType> GetMakeupType()
        {
            MakeupTypeRepository repo = new MakeupTypeRepository();
            return repo.GetMakeupTypes();
        }
        public static MakeupType GetMakeupTypeByID(int id)
        {
            MakeupTypeRepository repo = new MakeupTypeRepository();
            return repo.GetMakeupTypeById(id);
        }

        public static string insertMakeupType(string name)
        {
            MakeupTypeRepository repo = new MakeupTypeRepository();
            repo.insertMakeupType(repo.automateID(), name);
            return "success";
        }

        public static string updateMakeupType(int id, string name)
        {
            MakeupTypeRepository repo = new MakeupTypeRepository();
            repo.updateMakeupType(id, name);
            return "success";
        }

        public static string deleteMakeupType(int id)
        {
            MakeupRepository mrepo = new MakeupRepository();
            MakeupTypeRepository trepo = new MakeupTypeRepository();

            mrepo.DeleteMakeupByTypeID(id);
            trepo.deleteMakeupType(id);

            return "success";
        }
    }
}