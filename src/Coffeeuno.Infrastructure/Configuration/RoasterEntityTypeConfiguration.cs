using Coffeeuno.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coffeeuno.Infrastructure.Configuration;

internal class RoasterEntityTypeConfiguration : IEntityTypeConfiguration<Roaster>
{
    public void Configure(EntityTypeBuilder<Roaster> builder)
    {
        builder.HasKey(x => x.Id);
    }
}