using System.Globalization;

namespace IceAge.City.ZivilCity
{
    public class ZivilCity : BaseCity
    {
        int Workers { get; set; } = 0;
        ZivilCityStages Stage { get; set; }

        // Constructor
        public ZivilCity(ZivilCityStages stage, CultureTypes culture)
        {
            Culture = culture;
            Stage = stage;
        }

        // Update the stage of the city based on the development and active military personnel
        public void StageUpdate()
        {
            // Update the stage of the city
            // Based on Wealth, Population, Size, Development, ActiveMilitaryPersonnel
            
            if (Development < 20 && ActiveMilitaryPersonnel < 500)
            {
                Stage = ZivilCityStages.Village;
            }
            else if (Development < 30 && ActiveMilitaryPersonnel < 1000)
            {
                Stage = ZivilCityStages.Town;
            }
            else if (Development < 40 && ActiveMilitaryPersonnel < 5000)
            {
                Stage = ZivilCityStages.City;
            }
            else if (Development >= 40 && ActiveMilitaryPersonnel >= 15000)
            {
                Stage = ZivilCityStages.Metropolis;
            }
        }
        
        // Assign workers to the city
        // TODO: Implement the method to automatically assign workers to the city
        public void AssignWorkers(int numberOfWorkers)
        {
            Workers += numberOfWorkers;
        }
        
    }
}