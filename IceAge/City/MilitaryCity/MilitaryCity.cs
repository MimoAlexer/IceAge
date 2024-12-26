// IceAge/City/MilitaryCity/MilitaryCity.cs
using System.Globalization;

namespace IceAge.City.MilitaryCity;

public class MilitaryCity : BaseCity
{
    int Tanks { get; set; } = 0;
    int Aircrafts { get; set; } = 0;
    int Ships { get; set; } = 0;
    int Weapons { get; set; } = 0; 
    
    // Constructor
    public MilitaryCity(CultureTypes culture)
    {
        ActiveMilitaryPersonnel = 10;
        Culture = culture;
    }
    
    // Train soldiers for the city
    public void Train()
    {
        Random random = new Random();
        ActiveMilitaryPersonnel += random.Next(1, 5);
    }
    
    public void BuildTank()
    {
        Tanks++;
    }

    public void BuildAircraft()
    {
        Aircrafts++;
    }

    public void BuildShip()
    {
        Ships++;
    }

    public void ProduceWeapons(int amount)
    {
        Weapons += amount;
    }

    // Update the strength of the city
    public void UpdateStrength()
    {
        Strength = ActiveMilitaryPersonnel + Tanks + Aircrafts + Ships + Weapons;
    }
    
    // Todo: Need to implement the automatic building of tanks, aircrafts, ships, and weapons
}