using Coffeeuno.Domain;
using Coffeeuno.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coffeeuno.Infrastructure.Configuration;

internal class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Roaster>
{
    public void Configure(EntityTypeBuilder<Roaster> builder)
    {
        builder.HasKey(x => x.Id);
        builder.OwnsOne<MoneyValueObject>("_price", b =>
        {
            b.Property(p => p.Value).HasColumnName("ProductPriceValue");
            b.Property(p => p.Currency).HasColumnName("ProductPriceCurrency");
        });
    }
}