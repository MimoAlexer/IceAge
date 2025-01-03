namespace IceAge.War;

/// <summary>
/// Types of wars that can occur in the game.
/// </summary>
public enum WarTypes
{
    /// <summary>
    /// When a country invades another country, for land, resources, or other reasons.
    /// </summary>
    Invasion,
    
    /// <summary>
    /// When a country is under siege by another country, usually to force a surrender.
    /// </summary>
    Siege,
    
    /// <summary>
    /// When a country is colonizing another country, usually to expand its territory,
    /// or to spread its culture and influence.
    /// </summary>
    Colonization,
    
    /// <summary>
    /// Occurs when a city in a country are rebelling against the government.
    /// </summary>
    Rebellion,
    
    /// <summary>
    /// Same as the Rebellion war type, but on a larger scale, involving multiple cities or regions.
    /// </summary>
    CivilWar,
    
    /// <summary>
    /// When multiple countries are fighting against each other, usually for political or territorial reasons.
    /// </summary>
    WorldWar,
    
    /// <summary>
    /// Its not a real war, but a period of political tension and military rivalry between countries.
    /// </summary>
    ColdWar
}