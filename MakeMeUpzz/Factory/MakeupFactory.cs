using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factory
{
    public class MakeupFactory
    {
        public Makeup createMakeup(int id, string name, int price, int weight, int typeid, int brandid)
        {
            Makeup makeup = new Makeup();
            makeup.MakeupID = id;
            makeup.MakeupName = name;
            makeup.MakeupPrice = price;
            makeup.MakeupWeight = weight;
            makeup.MakeupTypeID = typeid;
            makeup.MakeupBrandID = brandid;

            return makeup;
        }
    }
}