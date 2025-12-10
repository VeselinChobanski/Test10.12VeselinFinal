
using System.Collections.Generic;

namespace ConsoleApp1;

public class ConsoleExerciseView
{
    private Controller _controller;

    public ConsoleExerciseView()
    {
        _controller = new Controller();
    }
    public void Run()
    {

        Console.WriteLine("fitness app");
        while (true)
        {
            Console.WriteLine("1 add");
            Console.WriteLine("2 list");
            Console.WriteLine("3 max");
            Console.WriteLine("4 exit");

            var input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("exercise name:");
                var name = Console.ReadLine();
                Console.WriteLine("calories:");
                var calories = int.Parse(Console.ReadLine());
                _controller.AddExercise(name, calories);
            }
            else if (input == "2")
            {
                _controller.GetAllExercisesString();
            }
            else if (input == "3")
            {
                Exercise exercise = _controller.GetMaxCaloriesExercise();
                Console.WriteLine($"{exercise.Id} {exercise.Name} {exercise.CaloriesBurned}"); 
            }


            else if (input == "4")
                {
                    return;
                }
            }
        }

    } 

