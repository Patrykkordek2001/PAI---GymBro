namespace API.Models
{
    public class Workout
    {
        public Workout(int id, DateTime workoutDate, string title, string description, int exerciseID)
        {
            Id = id;
            WorkoutDate = workoutDate;
            Title = title;
            Description = description;
            ExerciseID = exerciseID;
        }

        public int Id { get; set; }
        public DateTime WorkoutDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ExerciseID { get; set; }
        public virtual Excercise Excercise { get; set; }
    }
}
