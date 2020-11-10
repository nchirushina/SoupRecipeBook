using SoupRecipeBook.Models;
using System;


namespace SoupRecipeBook.Providers
{
    public abstract class BaseCookProvider : ICookProvider
    {
        public Broth GetBroth()
        {
            if (this.HasWater() && this.HasMeat())
            {
                var boiledWater = this.BoilWater();

                return this.AddToMeat(boiledWater);
            }
            throw new Exception("Cook provider s not ready");
        }

        public abstract bool HasWater();
        public abstract bool HasMeat();
        public abstract Water BoilWater();
        public abstract Broth AddToMeat(Water water);
    }

    
}
