using EF_Home_Work_Seven_.Context;
using StoreAppProject.Exceptions;
using StoreAppProject.Helper;
using StoreAppProject.Models;
using StoreAppProject.Services;

StoreAppDatabase database = new StoreAppDatabase();

ProductService productService = new ProductService(database);
UserService userService = new UserService(database);
while (true)
{
    Console.WriteLine("1.SignIn");
    Console.WriteLine("2.SignUp");
    Console.Write("Choice: ");
    int choice1 = int.Parse(Console.ReadLine());
    if (choice1 == 1)
    {
        Console.Write("Username:");
        string username = Console.ReadLine();
        Console.Write("Password:");
        string password = Console.ReadLine();
        if (userService.SignIn(username, password))
        {
            Console.WriteLine("Sign in successful.");
            while (true)
            {

                Console.WriteLine("Welcome to store");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. All Products");
                Console.WriteLine("3. Get Product by ID");
                Console.WriteLine("4. Remove Product");
                Console.WriteLine("5.Get Order By ID");
                Console.WriteLine("6.All Orders");
                Console.WriteLine("7.Remove Order");
                Console.WriteLine("8.AddCustomer");
                Console.WriteLine("9.GetCustomerById");
                Console.WriteLine("10.All Customers");
                Console.Write("Choice:");
                int choice = int.Parse(Console.ReadLine());
                try
                {

                    switch (choice)
                    {
                        case 1:

                            productService.Add(ProductConsoleInput.ConsoleInput());
                            Console.WriteLine("Product added successfullyy.");
                            break;
                        case 2:
                            productService.GetAll().ForEach(Console.WriteLine);
                            break;
                        case 3:
                            Console.WriteLine("Enter Product ID:");
                            int id = int.Parse(Console.ReadLine());
                            Product product = productService.GetById(id);
                            if (product != null)
                            {
                                Console.WriteLine(product);
                            }
                            else
                            {
                                Console.WriteLine("Product not found.");
                            }
                            break;
                    }
                }
                catch (InvalidPriceException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ProductNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An unexpected error occurred: " + ex.Message);
                }
                finally
                {
                    database.SaveChanges();
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid username or password. Please try again.");
        }
    }
    else if (choice1 == 2)
    {
        Console.Write("Username:");
        string username = Console.ReadLine();
        Console.Write("Password:");
        string password = Console.ReadLine();
        userService.SignUp(username, password);
    }
}