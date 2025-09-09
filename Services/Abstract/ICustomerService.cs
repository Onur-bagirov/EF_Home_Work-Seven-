using StoreAppProject.Models;

namespace StoreAppProject.Services.Abstract;

public interface ICustomerService
{
    public void Add(Customer item);
    public void Remove(Customer item);
    public Customer GetById(int id);
    public List<Customer> GetAll();
}