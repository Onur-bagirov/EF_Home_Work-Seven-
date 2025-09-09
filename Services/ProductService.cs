using EF_Home_Work_Seven_.context;
using StoreAppProject.Database;
using StoreAppProject.Exceptions;
using StoreAppProject.Models;
using StoreAppProject.Services.Abstract;

namespace StoreAppProject.Services;

public class ProductService : BaseService, IProductService
{
    public ProductService(StoreAppDatabase database) : base(database)
    {
    }

    public void Add(Product item)
    {
        _database.Products.Add(item);
    }

    public List<Product> GetAll()
    {
        return _database.Products;
    }

    public Product GetById(int id)
    {
        //    foreach (var product in _database.Products)
        //    {
        //        if (product.Id == id)
        //        {
        //            return product;
        //        }
        //    }
        //    return null;

        var product = _database.Products.FirstOrDefault(p => p.Id == id);
        if (product is null)
        {
            throw new ProductNotFoundException();
        }
        return product;
    }

    public Product GetByName(string name)
    {
        return _database.Products.FirstOrDefault(p => p.Name == name);
    }

    public void Remove(Product item)
    {
        var productToRemove = GetById(item.Id);
        if (productToRemove != null)
        {
            _database.Products.Remove(productToRemove);
        }
    }
}