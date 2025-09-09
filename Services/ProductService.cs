using EF_Home_Work_Seven_.Context;
using Microsoft.EntityFrameworkCore.Storage;
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
        _database.Product.Add(item);
    }

    public List<Product> GetAll()
    {
        return _database.Product.ToList();
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

        var product = _database.Product.FirstOrDefault(p => p.Id == id);
        if (product is null)
        {
            throw new ProductNotFoundException();
        }
        return product;
    }

    public Product GetByName(string name)
    {
        return _database.Product.FirstOrDefault(p => p.Name == name);
    }

    public void Remove(Product item)
    {
        var productToRemove = GetById(item.Id);
        if (productToRemove != null)
        {
            _database.Product.Remove(productToRemove);
        }
    }
}