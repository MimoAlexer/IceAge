namespace IceAge.War;

/// <summary>
/// War Object that contains the Attacker, Defender, and WarType properties.
/// </summary>
public class War
{
    /// <summary>
    /// Attacker in this War 
    /// </summary>
    public Country.Country Attacker { get; set; }
    
    /// <summary>
    /// Defender in this War
    /// </summary>
    public Country.Country Defender { get; set; }
    
    /// <summary>
    /// Wartype of this War
    /// </summary>
    public WarTypes WarType { get; set; }

    /// <summary>
    /// War constructor that initializes the Attacker, Defender, and WarType properties.
    /// </summary>
    /// <param name="attacker">Attacker in War</param>
    /// <param name="defender">Defender in War</param>
    /// <param name="warType">The wartype of this War</param>
    public War(Country.Country attacker, Country.Country defender, WarTypes warType)
    {
        Attacker = attacker;
        Defender = defender;
        WarType = warType;
    }
}