using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.EntityConfiguration
{
    public class WorkoutEntityConfiguration : IEntityTypeConfiguration<Workout>
    {
        public void Configure(EntityTypeBuilder<Workout> builder)
        {
            builder.ToTable("Workouts");
            builder.HasKey(e => e.Id);
            builder.Property(c => c.WorkoutDate).IsRequired(true);
            builder.Property(c => c.Title).IsRequired(true);
            builder.Property(c => c.Description).IsRequired(true);
            builder.Property(c => c.ExerciseID).IsRequired(true);
    }
    }
}
