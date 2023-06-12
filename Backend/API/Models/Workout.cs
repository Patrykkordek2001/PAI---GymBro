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
        public Guid? UserID { get; set; }
        public User User { get; set; }

    }
}
