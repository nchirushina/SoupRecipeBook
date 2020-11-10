using SoupRecipeBook.Models;
using SoupRecipeBook.Providers;
using System;


namespace SoupRecipeBook.Manager
{
    public class Hostess : IHostess
   //poijpo9hipo
    {
        private readonly ICookProvider cookProvider;

        public Hostess (ICookProvider cookProvider)
        {
            this.cookProvider = cookProvider;
        }
        public Borsch ServeBorsch()
        {
            Broth broth = this.cookProvider.GetBroth();
            var borsch = this.AddBeetroot(broth);

            return borsch;
        }

        public Broth ServeBroth()
        {
            return this.cookProvider.GetBroth();
        }

        public Shchi ServeShchi()
        {
            Broth broth = this.cookProvider.GetBroth();
            var shchi=this.AddCabbage(broth);

            return shchi;
        }

        private Borsch AddBeetroot (Broth broth)
        {
            return new Borsch();
        }

        private Shchi AddCabbage(Broth broth)
        {
            return new Shchi();
        }
    };
    
}
