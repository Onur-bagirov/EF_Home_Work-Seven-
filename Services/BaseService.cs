using EF_Home_Work_Seven_.context;
using StoreAppProject.Database;
using StoreAppProject.Models;

namespace StoreAppProject.Services;

public abstract class BaseService
{
    protected StoreAppDatabase _database;
    public BaseService(StoreAppDatabase database)
    {
        _database = database;
    }

}