using Microsoft.EntityFrameworkCore;

public class PoliceContext : DbContext
{
    public DbSet<Policeman> Policemen { get; set; }
    public DbSet<Offender> Offenders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PoliceDB;Trusted_Connection=True;")
            .UseLazyLoadingProxies();
    }
}
