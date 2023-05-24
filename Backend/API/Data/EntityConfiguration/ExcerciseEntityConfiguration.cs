using API.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace API.Data.EntityConfiguration
{
    public class ExcerciseEntityConfiguration : IEntityTypeConfiguration<Excercise>
    {
        public void Configure(EntityTypeBuilder<Excercise> builder)
        {
            builder.ToTable("Excercises");
            builder.HasKey(e => e.Id);
            builder.Property(c => c.Name).IsRequired(true);
            builder.Property(c => c.NumberOfRepetitions).IsRequired(true);
            builder.Property(c => c.NumberOfSeries).IsRequired(true);
            builder.Property(c => c.Type).IsRequired(true);
            builder.Property(c => c.WorkoutID).IsRequired(true);
        }
    }
}
