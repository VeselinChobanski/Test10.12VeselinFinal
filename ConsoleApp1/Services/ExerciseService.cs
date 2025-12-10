
namespace ConsoleApp1;

public class ExerciseService : IExerciseService
{
    private List<Exercise> _list;

    private bool isContains(string name)
    {
        bool result = false;
        foreach (Exercise exercise in _list)
        {
            if (name == exercise.Name) 
            { 
                result = true;
            }
        }
        return result;
    }

    public ExerciseService()
    {
        _list = new List<Exercise>();
    }

    public void AddExercise(string name, int calories)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentNullException("NULL or Empty");
        }
        if (calories < 0)
        {
            throw new ArgumentException("Negative calories.");
        }
        if (isContains(name) == true)
        {
            throw new ArgumentException("Name is found.");
        }
        _list.Add(new Exercise(_list.Count+1,name,calories));
    }

    public List<Exercise> GetAllExercises()
    {
        if (_list.Count == 0)
        {
            return null;
        }
       return _list;
    }

    //
    public string GetAllExercisesString()
    {
        string result = "";
        foreach (var item in _list)
        {
            result += $"{item.Id} {item.Name} {item.CaloriesBurned}";
        }
        return result;
    }
    //


    public Exercise GetMaxCaloriesExercise()
    {
        if (_list.Count == 0)
        {
            return null;
        }
        Exercise best = _list[0];
        foreach (var item in _list)
        {
            if (item.CaloriesBurned > best.CaloriesBurned)
            {
                best = item;
            }
        }
        return best;
    }

    public double GetTotalCalories()
    {
        double sum = 0;
        foreach (var item in _list)
        {
            sum += item.CaloriesBurned;
        }
        return sum;
    }

    
}
