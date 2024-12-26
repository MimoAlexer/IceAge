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
    
    // Output Iron Ore
    public void OutputQuartzite()
    {
        Random random = new Random();
        Quartzite += random.Next(1, 20);
        if (Quartzite > Warehouses * 500)
        {
            Quartzite = Warehouses * 200;
        }
    }
    
    // Produce Iron
    public void ProduceSilicon()
    {
        Random random = new Random();
        int amount = random.Next(1, 30);
        if (Quartzite < amount)
        {
            Silicon = Quartzite;
            Quartzite = 0;
        }
        else
        {
            Silicon = amount;
            Quartzite -= amount;
        }
    }
}