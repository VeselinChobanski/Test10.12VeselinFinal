using ConsoleApp1;

namespace Tests
{
    public class Tests
    {
        ExerciseService _service;

        [SetUp]
        public void Setup()
        {
            _service = new ExerciseService();
        }

        [Test]
        public void AddExercise_ValidData_AddsExerciseToList()
        {
            _service.AddExercise("Push-Ups", 120);
            string result = _service.GetAllExercisesString();
            Assert.That(result, Is.EqualTo($"1 Push-Ups 120"));
        }
        [Test]  

        public void AddExercise_DuplicateName_ThrowsArgumentException()
        {
            _service.AddExercise("Squats",150);
            Assert.Throws<ArgumentException>(() =>
            {
                _service.AddExercise("Squats", 55);
            });
        }

        [Test]

        public void GetMaxCaloriesExercise_EmptyCollection_ReturnsNull()
        {
            Exercise result = _service.GetMaxCaloriesExercise();
            Assert.That(result, Is.EqualTo(null));
        }

        [Test]

        public void GetMaxCaloriesExercise_ReturnsCorrectExercise()
        {
            _service.AddExercise("Exercise", 120);
            _service.AddExercise("Push-Ups", 230);
            _service.AddExercise("Jumping Jacks", 550);

            Exercise expected = _service.GetMaxCaloriesExercise();

            Assert.That(expected.Name, Is.EqualTo("Jumping Jacks"));
        }

        [Test]

        public void GetTotalCalories_NoExercises_ReturnsZer()
        {
            double result = _service.GetTotalCalories();
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]  

        public void GetTotalCalories_ReturnsCorrectSum()
        {
            _service.AddExercise("Exercise", 120);
            _service.AddExercise("Push-Ups", 230);
            _service.AddExercise("Jumping Jacks", 550);

            double result = _service.GetTotalCalories();

            Assert.That(result, Is.EqualTo(900));
        }
    }
}
