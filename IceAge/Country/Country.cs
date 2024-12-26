using IceAge.City.MilitaryCity;
using IceAge.City.OilCity;
using IceAge.City.ZivilCity;

namespace IceAge.Country;

public class Country
{
    public string Name { get; set; }
    public List<ZivilCity> ZivilCities { get; set; } = new List<ZivilCity>();
    public List<OilCity> OilCities { get; set; } = new List<OilCity>();
    public List<MilitaryCity> MilitaryCities { get; set; } = new List<MilitaryCity>();
    public List<Country> Enemies { get; set; } = new List<Country>();
    public List<Country> Allies { get; set; } = new List<Country>();

    public Country(string name)
    {
        Name = name;
    }

    public void DeclareWar(Country enemy)
    {
        Enemies.Add(enemy);
    }

    public void DefendWar(Country enemy)
    {
        Enemies.Add(enemy);
    }

    public void MakePeace(Country country)
    {
        Enemies.Remove(country);
    }

    public int GetStrength()
    {
        return ZivilCities.Sum(city => city.Strength) +
               OilCities.Sum(city => city.Strength) +
               MilitaryCities.Sum(city => city.Strength);
    }
}