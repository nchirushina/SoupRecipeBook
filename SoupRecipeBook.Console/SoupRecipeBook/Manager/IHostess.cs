
using SoupRecipeBook.Models;


namespace SoupRecipeBook.Manager
{
    public interface IHostess
    {
        Borsch ServeBorsch();

        Shchi ServeShchi();

        Broth ServeBroth();
    }
}
