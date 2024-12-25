namespace IceAge.Time;

public class TimeManager
{
    String Date { get; set; } = "{Day}, {Month}, {Year}";
    int Day { get; set; }
    Month Month { get; set; }
    int Year { get; set; }
    
    // Adds a day to the date and adds switch year
    
    /// <summary>
    /// Returns the number of days in the specified month for the current year.
    /// Accounts for leap years in the case of February.
    /// </summary>
    /// <param name="month">The month for which to get the number of days.</param>
    /// <returns>The number of days in the specified month.</returns>
    private int GetDaysInMonth(Month month)
    {
        return month switch
        {
            Month.February => (Year % 4 == 0 && (Year % 100 != 0 || Year % 400 == 0)) ? 29 : 28,
            Month.April or Month.June or Month.September or Month.November => 30,
            _ => 31,
        };
    }
    
    /// <summary>
    /// The UpdateDate method updates the date by incrementing the day.
    /// If the day exceeds the number of days in the current month, it resets the day to 1 and increments the month.
    /// If the month is December, it also increments the year.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the month is out of range.</exception>
    
    // This was harder than I thought
    public void UpdateDate()
    {
        if (Day > GetDaysInMonth(Month))
        {
            Day = 1;
            if (Month == Month.December)
            {
                Month = Month.January;
                Year++;
            }
            else
            {
                Month = Month switch
                {
                    Month.January => Month.February,
                    Month.February => Month.March,
                    Month.March => Month.April,
                    Month.April => Month.May,
                    Month.May => Month.June,
                    Month.June => Month.July,
                    Month.July => Month.August,
                    Month.August => Month.September,
                    Month.September => Month.October,
                    Month.October => Month.November,
                    Month.November => Month.December,
                    _ => throw new ArgumentOutOfRangeException()
                };
            }
        }
    }
}