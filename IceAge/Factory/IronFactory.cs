namespace IceAge.Factory;

public class IronFactory
{
    int Warehouses { get; set; }
    int Workers { get; set; }
    int IronOre { get; set; } = 0;
    private int Iron { get; set; } = 0;
    private int Steel { get; set; } = 0;
    
    // Constructor
    public IronFactory(int warehouses, int workers, int ironOre, int iron, int steel)
    {
        Warehouses = warehouses;
        Workers = workers;
    }
    
    //TODO: Needs a System for automatically producing Iron and Steel
}