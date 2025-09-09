using EF_Home_Work_Seven_.Context;
using StoreAppProject.Models;
using StoreAppProject.Services.Abstract;
using System.Security.Cryptography;

namespace StoreAppProject.Services;

public class UserService : BaseService, IUserService
{
    public UserService(StoreAppDatabase database) : base(database)
    {
    }

    public bool SignIn(string username, string password)
    {
        bool sign = false;
        var users = _database.User;
        foreach (var user in users)
        {
            if (user.Username == username && user.Password == password)
            {
                sign = true;
            }
        }
        return sign;
    }

    public void SignUp(string username, string password)
    {
        User user = new User()
        {
            Username = username,
            Password = password
        };
        _database.User.Add(user);
    }
}