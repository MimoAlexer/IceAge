namespace IceAge.War;

public class Diplomacy
{
    public Dictionary<IceAge.Country.Country, List<IceAge.Country.Country>> Alliances { get; set; } = new Dictionary<IceAge.Country.Country, List<IceAge.Country.Country>>();

    // Form alliance between two countries
    public void FormAlliance(IceAge.Country.Country country1, IceAge.Country.Country country2)
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

    // Break alliance between two countries
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