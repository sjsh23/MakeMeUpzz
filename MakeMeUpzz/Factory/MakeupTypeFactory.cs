using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factory
{
    public class MakeupTypeFactory
    {
        public MakeupType createMakeupType(int id, string name)
        {
            MakeupType makeupType = new MakeupType();
            makeupType.MakeupTypeID = id;
            makeupType.MakeupTypeName = name;

            return makeupType;
        }
    }
}