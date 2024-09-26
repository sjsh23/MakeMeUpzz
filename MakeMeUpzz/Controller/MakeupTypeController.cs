using MakeMeUpzz.Model;
using MakeMeUpzz.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MakeMeUpzz.Repository;

namespace MakeMeUpzz.Controller
{
    public class MakeupTypeController
    {
        public static List<MakeupType> getMakeupType()
        {
            return MakeupTypeHandler.GetMakeupType();
        }

        public static MakeupType GetMakeupTypeByID(int id)
        {
            return MakeupTypeHandler.GetMakeupTypeByID(id);
        }

        public static string insertMakeupType(string name)
        {
            if(name == null || name.Length == 0)
            {
                return "please input name";
            }
            else if(name.Length < 1 || name.Length > 99)
            {
                return "name must be between 1 and 99 characters";
            }
            else
            {
                return MakeupTypeHandler.insertMakeupType(name);
            }
        }

        public static string updateMakeupType(int id, string name)
        {
            if (name == null || name.Length == 0)
            {
                return "please input name";
            }
            else if (name.Length < 1 || name.Length > 99)
            {
                return "name must be between 1 and 99 characters";
            }
            else
            {
                return MakeupTypeHandler.updateMakeupType(id, name);
            }
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