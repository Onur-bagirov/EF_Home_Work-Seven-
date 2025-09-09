using EF_Home_Work_Seven_.context;
using StoreAppProject.Database;
using StoreAppProject.Models;
using StoreAppProject.Services.Abstract;

namespace StoreAppProject.Services;

public class CustomerService : BaseService, ICustomerService
{
    public CustomerService(StoreAppDatabase database) : base(database)
    {
    }

    public void Add(Customer item)
    {
        throw new NotImplementedException();
    }

    public List<Customer> GetAll()
    {
        throw new NotImplementedException();
    }

    public Customer GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Remove(Customer item)
    {
        throw new NotImplementedException();
    }
}