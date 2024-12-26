namespace IceAge.Family;

public class FamilyMember
{
    // TODO: Add Birthdate property with TimeManager.cs
    public string Name { get; set; }
    public Role Role { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public static List <FamilyMember> DeadMembers = new List<FamilyMember>();

    // Constructor
    public FamilyMember(string name, Role role, int age, string gender)
    {
        Name = name;
        Role = role;
        Age = age;
        Gender = gender;
    }
    
    /// <summary>
    /// Adds the member to DeadList
    /// Trys to search members family and removes the member from the family
    /// </summary>
    
    public void Die()
    {
        DeadMembers.Add(this);
        Family? family = Family.GetFamilyByMember(this);
        if(family != null)
        {
            family.RemoveMember(this.Name);
        }
    }
    
    public void AddToFamily(Family family)
    {
        family.AddMember(this);
    }
    
    // Makes the member older
    public void GetOlder()
    {
        Age++;
    }
    
    // Makes the member younger
    public void GetYounger()
    {
        Age--;
    }
}