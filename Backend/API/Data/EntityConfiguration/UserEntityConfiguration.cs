using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Data.EntityConfiguration
{
    internal class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
            public void Configure(EntityTypeBuilder<User> builder)
            {
                builder.ToTable("Users");
                builder.HasKey(e => e.Id);
                builder.Property(c => c.UserName).IsRequired(true);
                builder.Property(c => c.Password).IsRequired(true);
                builder.Property(c => c.Email).IsRequired(true);
                builder.Property(c => c.Name).IsRequired(true); 
            }
        

    }
}
