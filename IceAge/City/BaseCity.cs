using System.Globalization;
using IceAge.Family;

namespace IceAge.City;

public class BaseCity
{
    public int Strength { get; set; } = 1;
    private int Population { get; set; } = ActiveMilitaryPersonnel + Zivilians;
    static int Zivilians { get; set; }
    private int Size { get; set; } = 1;
    private int Wealth { get; set; } = 1;
    int Power { get; set; } = 1;
    public static int ActiveMilitaryPersonnel { get; set; } = 0;
    public int Development { get; set; } = 1;
    public static CultureTypes Culture { get; set; }
    private bool IsDestroyed { get; set; } = false;

    private List<IceAge.Family.Family> Families { get; set; } = new List<IceAge.Family.Family>();
    
    // Destroy the city
    public void Destroy()
    {
        IsDestroyed = true;
    }

    // Build the city to raise the development
    public void Build()
    {
        Random random = new Random();
        Development += random.Next(1, 5);
    }
    
    // Recruit soldiers for the city
    public void Recruit()
    {
        Random random = new Random();
        ActiveMilitaryPersonnel += random.Next(1, 5);
    }

    // Update the power of the city
    public void UpdatePower()
    {
        Power = Population + Size + Wealth + ActiveMilitaryPersonnel;
    }
    
    // Make kids for each family in the city
    public void MakeKids()
    {
        Random random = new Random();
        foreach (var family in Families)
        {
            var mother = family.GetMembersByRole(Role.Mother).FirstOrDefault();
            var father = family.GetMembersByRole(Role.Father).FirstOrDefault();

            if (mother != null && father != null)
            {
                int numberOfKids = random.Next(1, 4); // 1 to 3 kids
                for (int i = 0; i < numberOfKids; i++)
                {
                    var name = (Name)random.Next(Enum.GetValues(typeof(Name)).Length);
                    var gender = random.Next(2) == 0 ? "Male" : "Female";
                    var child = new FamilyMember(name.ToString(), Role.Child, 0, gender);
                    family.AddMember(child);
                }
                Zivilians += numberOfKids;
            }
        }
    }
    
    // Check if city is destroyed if population is less than 1
    public void CheckPopulation()
    {
        if (Population <= 1)
        {
            Destroy();
        }
    }
    
    // Add family to city
    public void AddFamily(IceAge.Family.Family family)
    {
        Families.Add(family);
    }
    
    // Get all families
    public List<IceAge.Family.Family> GetFamilies()
    {
        return Families;
    }

    // Get family by name
    public IceAge.Family.Family GetFamilyByName(string familyName)
    {
        return Families.FirstOrDefault(f => f.FamilyName == familyName);
    }
}