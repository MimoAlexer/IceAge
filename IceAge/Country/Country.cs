using IceAge.City.MilitaryCity;
using IceAge.City.OilCity;
using IceAge.City.ZivilCity;
using IceAge.Factory;

namespace IceAge.Country;

/// <summary>
/// Object representing a country in the game.
/// </summary>
public class Country
{
    // Properties
    /// <summary>
    /// Name of the country.
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Declares the continent the country is on.
    /// </summary>
    public Continents Continent { get; set; }
    
    /// <summary>
    /// Number of cities in the country.
    /// </summary>
    public List<ZivilCity> ZivilCities { get; set; } = new List<ZivilCity>();
    
    /// <summary>
    /// Number of oil cities in the country.
    /// </summary>
    public List<OilCity> OilCities { get; set; } = new List<OilCity>();
    
    /// <summary>
    /// Number of military cities in the country.
    /// </summary>
    public List<MilitaryCity> MilitaryCities { get; set; } = new List<MilitaryCity>();
    
    /// <summary>
    /// Number of ironfactories in the country.
    /// </summary>
    public List<IronFactory> IronFactories { get; set; } = new List<IronFactory>();
    
    /// <summary>
    /// Number of plasticfactories in the country.
    /// </summary>
    public List<PlasticFactory> PlasticFactories { get; set; } = new List<PlasticFactory>();
    
    /// <summary>
    /// Number of siliconfactories in the country.
    /// </summary>
    public List<SiliconFactory> SiliconFactories { get; set; } = new List<SiliconFactory>();
    
    /// <summary>
    /// A list of countries that are enemies with this country, within a war.
    /// </summary>
    public List<Country> Enemies { get; set; } = new List<Country>();
    
    /// <summary>
    /// List of countries that are allies with this country, within a war.
    /// </summary>
    public List<Country> Allies { get; set; } = new List<Country>();
    
    /// <summary>
    /// Constructor for the country object.
    /// </summary>
    /// <param name="name">Name of the Country as String</param>
    public Country(string name)
    {
        Name = name;
    }

    /// <summary>
    /// Declares war between this country and another country.
    /// </summary>
    /// <param name="enemy">The Country that declares the war</param>
    public void DeclareWar(Country enemy)
    {
        Enemies.Add(enemy);
        enemy.Enemies.Add(this);
    }
    
    /// <summary>
    /// Makes peace between this country and another country.
    /// </summary>
    /// <param name="country"></param>
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
    
    // TODO: Needs a system for taking cities and factories from other countries
}