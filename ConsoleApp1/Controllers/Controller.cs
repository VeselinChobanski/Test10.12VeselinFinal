
namespace ConsoleApp1;

public class Controller
{
    private ExerciseService _service;

    public Controller()
    {
        _service = new ExerciseService();
    }

    public void AddExercise(string name, int calories)
    {
        try
        {
            _service.AddExercise(name,calories);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public List<Exercise> GetAllExercises()
    {
        return _service.GetAllExercises();
    }

    public void GetAllExercisesString()
    {
        Console.WriteLine(_service.GetAllExercisesString());
    }

    public Exercise GetMaxCaloriesExercise()
    {
        return _service.GetMaxCaloriesExercise();
    }

    public double GetTotalCalories()
    {
        return _service.GetTotalCalories();
    }
}
