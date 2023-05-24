using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Excercise
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int NumberOfRepetitions { get; set; }
        public int NumberOfSeries { get; set; }
        public string Type { get; set; }
        public int WorkoutID { get; set; }
        public virtual ICollection<Workout> Workouts { get; set; }


    }
}
