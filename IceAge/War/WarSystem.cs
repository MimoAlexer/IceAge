namespace IceAge.War;

/// <summary>
/// A WarSystem class that manages all wars in the world.
/// </summary>
public class WarSystem
{
    /// <summary>
    /// List of all countries in the world.
    /// </summary>
    public List<Country.Country> Countries { get; set; } = new List<Country.Country>();
    
    /// <summary>
    /// List of all active wars in the world.
    /// </summary>
    public List<War> ActiveWars { get; set; } = new List<War>();

    /// <summary>
    /// Use this DeclareWar method to declare war between two countries. T
    /// his method will add a new war to the ActiveWars list and
    /// update the diplomatic status of the countries involved.
    /// </summary>
    /// <param name="attacker">Attacker of a War</param>
    /// <param name="defender">Defender of a War</param>
    /// <param name="warType">Typ of War: Invasion etc</param>
    public void DeclareWar(Country.Country attacker, Country.Country defender, WarTypes warType)
    {
        var war = new War(attacker, defender, warType);
        ActiveWars.Add(war);
        attacker.DeclareWar(defender);
    }
    
    /// <summary>
    /// Negotiates peace between two countries by removing the active war between them and updating their diplomatic status.
    /// Use this method to make peace between two countries, not the MakePeace method in the Country class.
    /// </summary>
    /// <param name="country1">The first country involved in the peace negotiation.</param>
    /// <param name="country2">The second country involved in the peace negotiation.</param>
    public void NegotiatePeace(Country.Country country1, Country.Country country2)
    {
        var war = ActiveWars.FirstOrDefault(w => (w.Attacker == country1 && w.Defender == country2) || (w.Attacker == country2 && w.Defender == country1));
        if (war != null)
        {
            ActiveWars.Remove(war);
            country1.MakePeace(country2);
            country2.MakePeace(country1);
        }
    }
    
    // TODO: Needs a system for automatic declaring of wars based on certain conditions
}