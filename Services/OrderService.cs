using EF_Home_Work_Seven_.Context;
using StoreAppProject.Models;
using StoreAppProject.Services.Abstract;

namespace StoreAppProject.Services;

public class OrderService : BaseService, IOrderService
{
    public OrderService(StoreAppDatabase database) : base(database)
    {
    }

    public void Add(Order item)
    {
        throw new NotImplementedException();
    }

    public List<Order> GetAll()
    {
        throw new NotImplementedException();
    }

    public Order GetByCustomerId(int customerId)
    {
        throw new NotImplementedException();
    }

    public Order GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Remove(Order item)
    {
        throw new NotImplementedException();
    }
}