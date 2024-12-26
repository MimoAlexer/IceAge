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
    
    // Output Iron Ore
    public void OutputIronOre()
    {
        Random random = new Random();
        IronOre += random.Next(1, 15);
        if (IronOre > Warehouses * 200)
        {
            IronOre = Warehouses * 200;
        }
    }
    
    // Produce Iron
    public void ProduceIron()
    {
        Random random = new Random();
        int amount = random.Next(1, 30);
        if (IronOre < amount)
        {
            Iron = IronOre;
            IronOre = 0;
        }
        else
        {
            Iron = amount;
            IronOre -= amount;
        }
    }
    
}