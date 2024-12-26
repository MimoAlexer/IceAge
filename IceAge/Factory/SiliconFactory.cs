namespace IceAge.Factory;

public class SiliconFactory
{
    int Warehouses { get; set; }
    int Workers { get; set; }
    int Silicon { get; set; } = 0;
    int Quartzite { get; set; } = 0;
    
    // Constructor
    public SiliconFactory(int warehouses, int workers)
    {
        Warehouses = warehouses;
        Workers = workers;
    }
    
    
}