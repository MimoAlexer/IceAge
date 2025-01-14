namespace IceAge.War;

/// <summary>
/// Diplomacy class that manages alliances between countries.
/// </summary>
public class Diplomacy
{
    /// <summary>
    /// Alliances between countries in the world.
    /// </summary>
    public Dictionary<IceAge.Country.Country, List<IceAge.Country.Country>> Alliances { get; set; } = new Dictionary<IceAge.Country.Country, List<IceAge.Country.Country>>();

    /// <summary>
    /// Form an alliance between two countries.
    /// </summary>
    /// <param name="country1">Country 1 of making a Alliance</param>
    /// <param name="country2">Country 2 of making a Alliance</param>
    public void FormAlliance(Country.Country country1, IceAge.Country.Country country2)
    {
        if (!Alliances.ContainsKey(country1))
        {
            Alliances[country1] = new List<IceAge.Country.Country>();
        }
        if (!Alliances.ContainsKey(country2))
        {
            Alliances[country2] = new List<IceAge.Country.Country>();
        }
        Alliances[country1].Add(country2);
        Alliances[country2].Add(country1);
    }

    /// <summary>
    /// Breaks a alliance between two countries.
    /// </summary>
    /// <param name="country1">Country 1 of breaking a alliance</param>
    /// <param name="country2">Country 2 of breaking a alliance</param>
    public void BreakAlliance(IceAge.Country.Country country1, IceAge.Country.Country country2)
    {
        if (Alliances.ContainsKey(country1))
        {
            Alliances[country1].Remove(country2);
        }
        if (Alliances.ContainsKey(country2))
        {
            Alliances[country2].Remove(country1);
        }
    }
}