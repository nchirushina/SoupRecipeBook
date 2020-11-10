using SoupRecipeBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoupRecipeBook.Providers
{
    public class Multicooker : BaseCookProvider, ICookProvider
    {
        public override Broth AddToMeat(Water water)
        {
            return new Broth();
        }

        public override Water BoilWater()
        {
            return new Water();
        }

        public override bool HasMeat()
        {
            return true;
        }

        public override bool HasWater()
        {
            return true;
        }
    }
}
