namespace IceAge.Family;

public class Family
{
    public string FamilyName { get; private set; }
    public List<FamilyMember> Members { get; private set; }

    // Constructor
    public Family(string familyName)
    {
        FamilyName = familyName;
        Members = new List<FamilyMember>();
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
}