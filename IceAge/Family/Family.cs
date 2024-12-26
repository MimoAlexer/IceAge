using IceAge.City;

namespace IceAge.Family;

public class Family
{
    public string FamilyName { get; private set; }
    public List<FamilyMember> Members { get; private set; }
    public static List<Family> Families = new List<Family>();
    public BaseCity HomeCity { get; set; }

    // Constructor
    public Family(string familyName, BaseCity homeCity)
    {
        FamilyName = familyName;
        Members = new List<FamilyMember>();
        HomeCity = homeCity;
        Families.Add(this);
    }
    
    // Add member to family
    public void AddMember(FamilyMember member)
    {
        Members.Add(member);
    }

    // Remove member by name
    public void RemoveMember(string memberName)
    {
        Members.RemoveAll(m => m.Name == memberName);
    }

    /// <summary>
    /// Not tested, maybe return null if not found
    /// Not tested, maybe return multiple members with the same name
    /// </summary>
    /// <param name="role">needs a role from Role.cs(enum)</param>
    /// <returns>returns a FamilyMember</returns>
    
    // Get members by role
    public List<FamilyMember> GetMembersByRole(Role role)
    {
        return Members.Where(m => m.Role == role).ToList();
    }

    // Get member by name
    public FamilyMember GetMemberByName(string name)
    {
        return Members.FirstOrDefault(m => m.Name == name);
    }

    // Get all members
    public List<FamilyMember> GetAllMembers()
    {
        return Members;
    }

    /// <summary>
    /// Returns the family of the given member when found
    /// </summary>
    /// <param name="member">Family of param will be searched</param>
    /// <returns>Returns Family from param if found, else returns null</returns>
    
    public static Family? GetFamilyByMember(FamilyMember member)
    {
        foreach (Family family in Families)
        {
            foreach (FamilyMember familyMember in family.Members)
            {
                if(familyMember == member)
                {
                    return family;
                }
            }
        }

        return null;
    }
    
    // TODO: Add method for making kids 1 M + 1 F = 1 C (1 to 3 kids) in 1 Year
    // TODO: Remove random Population maker in Cities
}