namespace IceAge.Factory;

public class PlasticFactory
{
    int Warehouse { get; set; }
    int Workers { get; set; }
    int Plastic { get; set; } = 0;
    int Oil { get; set; } = 0;
    
    // Constructor
    public PlasticFactory(int warehouse, int workers, int plastic, int oil)
    {
        Warehouse = warehouse;
        Workers = workers;
    }
    
    // TODO: Needs a System for automatically producing Plastic
    // Maybe add a System for trading(Trading oil for plastic)
}