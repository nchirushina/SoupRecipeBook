using SoupRecipeBook.Models;


namespace SoupRecipeBook.Providers
{
    public class SelfCooker : BaseCookProvider, ICookProvider
      
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
