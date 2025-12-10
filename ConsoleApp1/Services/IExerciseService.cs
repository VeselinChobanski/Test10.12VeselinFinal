using ConsoleApp1;

namespace ConsoleApp1;

public interface IExerciseService
{
    /// <summary>
    /// Добавя упражнение със зададено име и калории.
    /// Ако упражнение със същото име съществува хвърля ArgumentException.
    /// </summary>
    void AddExercise(string name, int calories);

    /// <summary>
    /// Връща всички упражнения.
    /// </summary>
    List<Exercise> GetAllExercises();

    /// <summary>
    /// Намира упражнението с най-много изгорени калории.
    /// Ако няма упражнения връща null.
    /// </summary>
    Exercise GetMaxCaloriesExercise();

    /// <summary>
    /// Изчислява общо изгорените калории.
    /// Ако няма упражнения връща 0.
    /// </summary>
    double GetTotalCalories();

}
