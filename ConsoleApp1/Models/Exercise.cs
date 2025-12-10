using System.Security.Principal;

namespace ConsoleApp1;

public class Exercise
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double CaloriesBurned { get; set; }

    public Exercise(int id, string name, double caloriesBurned)
    {
        Id = id;
        Name = name;
        CaloriesBurned = caloriesBurned;
    }
}
