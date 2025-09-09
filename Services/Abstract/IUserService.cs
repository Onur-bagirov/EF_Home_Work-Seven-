namespace StoreAppProject.Services.Abstract;

public interface IUserService
{
    public bool SignIn(string username, string password);
    public void SignUp(string username, string password);
}