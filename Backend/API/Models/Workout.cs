using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Workout
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime WorkoutDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ExerciseID { get; set; }
        public virtual Excercise Excercise { get; set; }
    }
}
