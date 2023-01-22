using ChatApplication.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChatApplication.Dal.EntityConfigurations
{
    public class UserProfileEntityConfiguration : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.HasMany(x => x.Messages)
                .WithOne(x => x.UserProfile);

            builder.HasMany(x => x.Replies)
                .WithOne(x => x.UserProfile);
        }
    }
}
