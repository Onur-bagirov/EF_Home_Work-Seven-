namespace StoreAppProject.Exceptions;

public class InvalidPriceException : Exception
{
    public InvalidPriceException() : base("The price cannot be negative") { }

}