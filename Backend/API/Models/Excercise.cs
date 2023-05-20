namespace API.Models
{
    public class Excercise
    {
        public Excercise(int id, string name, int numberOfRepetitions, int numberOfSeries, string type, int workoutID)
        {
            Id = id;
            Name = name;
            NumberOfRepetitions = numberOfRepetitions;
            NumberOfSeries = numberOfSeries;
            Type = type;
            WorkoutID = workoutID;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfRepetitions { get; set; }
        public int NumberOfSeries { get; set; }
        public string Type { get; set; }
        public int WorkoutID { get; set; }
        public virtual ICollection<Workout> Workouts { get; set; }


    }
}
