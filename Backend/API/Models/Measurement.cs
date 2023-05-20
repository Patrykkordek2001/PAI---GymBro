namespace API.Models
{
    public class Measurement
    {
        public int Id { get; set; }
        public DateTime MeasurementDate { get; set; }
        public double Weight { get; set; }
        public double Arms { get; set; }
        public double Chest { get; set; }
        public double Waist { get; set; }
        public double Hips { get; set; }
        public double Thighs { get; set; }
        
        public Measurement(int id, DateTime measurementDate, double weight, double arms, double chest, double waist, double hips, double thighs)
        {
            Id = id;
            MeasurementDate = measurementDate;
            Weight = weight;
            Arms = arms;
            Chest = chest;
            Waist = waist;
            Hips = hips;
            Thighs = thighs;
        }
    }
}
