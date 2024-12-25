namespace IceAge.Family;

public class FamilyMember
{
    public string Name { get; set; }
    public Role Role { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    // Constructor
    public FamilyMember(string name, Role role, int age, string gender)
    {
        Name = name;
        Role = role;
        Age = age;
        Gender = gender;
    }
}