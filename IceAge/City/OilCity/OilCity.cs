// IceAge/City/OilCity/OilCity.cs
using System.Globalization;

namespace IceAge.City.OilCity;

public class OilCity : BaseCity
{
    int LiterOfOil { get; set; } = 0;

    // Constructor
    public OilCity(CultureTypes culture)
    {
        LiterOfOil = 0;
        Culture = culture;
    }

    // Produce oil for the city
    public void ProduceOil()
    {
        Random random = new Random();
        LiterOfOil += random.Next(1, 100);
    }

    // Use oil for the city
    // TODO: Implement the method to use oil for the city automatically
    // TODO: Maybe add a parameter to specify the amount of oil to use
    // TODO: Maybe add Trading system to trade oil with other cities
    public void UseOil(int amount)
    {
        LiterOfOil -= amount;
    }
}