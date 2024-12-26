namespace IceAge.War;

public class WarSystem
{
    public List<Country.Country> Countries { get; set; } = new List<Country.Country>();
    public List<War> ActiveWars { get; set; } = new List<War>();

    // Declare war between two countries
    public void DeclareWar(Country.Country attacker, Country.Country defender, WarTypes warType)
    {
        var war = new War(attacker, defender, warType);
        ActiveWars.Add(war);
        attacker.DeclareWar(defender);
        defender.DefendWar(attacker);
    }
    
    /// <summary>
    /// Negotiates peace between two countries by removing the active war between them and updating their diplomatic status.
    /// </summary>
    /// <param name="country1">The first country involved in the peace negotiation.</param>
    /// <param name="country2">The second country involved in the peace negotiation.</param>
    
    // Negotiate peace between two countries
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