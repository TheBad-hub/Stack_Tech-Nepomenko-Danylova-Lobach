using Microsoft.EntityFrameworkCore;

public class Policeman
{
    public int PolicemanId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string BadgeNumber { get; set; }
    // Зв'язок "один до багатьох" - один поліцейський може затримати багато порушників
    public ICollection<Offender> Offenders { get; set; }
}

public class Offender
{
    public int OffenderId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string ViolationType { get; set; }
    // Зовнішній ключ на поліцейського
    public int PolicemanId { get; set; }
    public Policeman Policeman { get; set; }
    // Властивість для повного імені поліцейського
    public string PolicemanFullName => Policeman != null ? $"{Policeman.FirstName} {Policeman.LastName}" : "No Policeman";
}


public class PoliceContext : DbContext
{
    public DbSet<Policeman> Policemen { get; set; }
    public DbSet<Offender> Offenders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PoliceDB;Trusted_Connection=True;");
    }
}

public class Program
{
    public static void Main()
    {
        using (var context = new PoliceContext())
        {
            context.Database.EnsureCreated();
        }
    }
}