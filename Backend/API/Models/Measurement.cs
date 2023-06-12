using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Measurement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public Guid Id { get; set; }
        public DateTime MeasurementDate { get; set; }
        public double Weight { get; set; }
        public double Arms { get; set; }
        public double Chest { get; set; }
        public double Waist { get; set; }
        public double Hips { get; set; }
        public double Thighs { get; set; }
        public Guid? UserID { get; set; }
        public User? User { get; set; }


    }
}
