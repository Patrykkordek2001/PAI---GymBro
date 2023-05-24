using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.EntityConfiguration
{
    public class MeasurementEntityConfiguration : IEntityTypeConfiguration<Measurement>
    {
        public void Configure(EntityTypeBuilder<Measurement> builder)
        {
            builder.ToTable("Measurements");
            builder.HasKey(e => e.Id);
            builder.Property(c => c.MeasurementDate).IsRequired(true);
            builder.Property(c => c.Weight).IsRequired(true);
            builder.Property(c => c.Arms).IsRequired(true);
            builder.Property(c => c.Chest).IsRequired(true);
            builder.Property(c => c.Waist).IsRequired(true);
            builder.Property(c => c.Hips).IsRequired(true);
            builder.Property(c => c.Thighs).IsRequired(true);
        }
    }
}
