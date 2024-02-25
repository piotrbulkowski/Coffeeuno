using Coffeeuno.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Coffeeuno.Infrastructure;

public class CoffeeunoContext : DbContext
{
    public DbSet<Roaster> Roasters { get; set; }
    
    private readonly ILoggerFactory _loggerFactory;
    
    public CoffeeunoContext(DbContextOptions options, ILoggerFactory loggerFactory)
        : base(options)
    {
        _loggerFactory = loggerFactory;
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        => modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
}