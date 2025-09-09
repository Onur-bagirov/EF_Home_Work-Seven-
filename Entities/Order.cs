namespace StoreAppProject.Models;
public class Order : BaseModel
{
    public double TotalPrice { get; set; }
    public int ID_Customer { get; set; }
    public Customer Customer { get; set; }
    public List<Product> Products { get; set; }
}