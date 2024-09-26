using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factory
{
    public class MakeupBrandFactory
    {
        public MakeupBrand createMakeupBrand(int id, string name, int rating)
        {
            MakeupBrand makeupBrand = new MakeupBrand();
            makeupBrand.MakeupBrandID = id;
            makeupBrand.MakeupBrandName = name;
            makeupBrand.MakeupBrandRating = rating;

            return makeupBrand;
        }
    }
}