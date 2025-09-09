namespace StoreAppProject.Models;
public abstract class BaseModel
{
    private static int _counter = 0;
    public int Id { get; private set; }
    protected BaseModel()
    {
        _counter++;
        Id = _counter;
    }
}