namespace IceAge.War;

public class War
{
    public Country.Country Attacker { get; set; }
    public Country.Country Defender { get; set; }
    public WarTypes WarType { get; set; }

    // Constructor
    public War(Country.Country attacker, Country.Country defender, WarTypes warType)
    {
        Attacker = attacker;
        Defender = defender;
        WarType = warType;
    }
}