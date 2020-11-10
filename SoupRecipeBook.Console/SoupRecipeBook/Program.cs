using SoupRecipeBook.Manager;
using SoupRecipeBook.Providers;
using System;

namespace SoupRecipeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookProvider = new Multicooker();
            var hostess = new Hostess(cookProvider);
            
            var newSoup = hostess.ServeBorsch();


            Console.WriteLine(newSoup);
        }
    }
}
