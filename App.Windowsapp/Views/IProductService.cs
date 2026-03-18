using App.Core.Models;

namespace App.Windowsapp.Views
{
    public interface IProductService
    {
        Product Add(Product newProduct);
        bool Update(Product product);
    }
}