using StoreAppProject.Models;

namespace StoreAppProject.Services.Abstract;

public interface IOrderService
{
    public void Add(Order item);
    public void Remove(Order item);
    public Order GetById(int id);
    public List<Order> GetAll();
    public Order GetByCustomerId(int customerId);
}