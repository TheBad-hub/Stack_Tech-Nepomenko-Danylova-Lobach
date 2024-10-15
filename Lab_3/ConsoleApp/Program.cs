using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Linq;

public class Policeman
{
    public int PolicemanId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string BadgeNumber { get; set; }
    public virtual ICollection<Offender> Offenders { get; set; }
}

public class Offender
{
    public int OffenderId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string ViolationType { get; set; }
    public int PolicemanId { get; set; }
    public virtual Policeman Policeman { get; set; }
    public string PolicemanFullName => Policeman != null ? $"{Policeman.FirstName} {Policeman.LastName}" : "No Policeman";
}

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

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        using (var context = new PoliceContext())
        {
            context.Database.EnsureCreated();

            DisplayPolicemen(context);
            DisplayOffenders(context);
        }
    }

    private static void DisplayPolicemen(PoliceContext context)
    {
        var policemen = context.Policemen.ToList(); // Лениво загружает правопорушників при доступе
        Console.WriteLine("Поліцейські:");
        foreach (var policeman in policemen)
        {
            Console.WriteLine($"ID: {policeman.PolicemanId}, Ім'я: {policeman.FirstName}, Прізвище: {policeman.LastName}, Номер значка: {policeman.BadgeNumber}, Правопорушники: {FormatOffenders(policeman.Offenders)}");
        }
        Console.WriteLine();
    }

    private static void DisplayOffenders(PoliceContext context)
    {
        var offenders = context.Offenders.ToList(); // Лениво загружает поліцейських при доступе
        Console.WriteLine("Порушники:");
        foreach (var offender in offenders)
        {
            Console.WriteLine($"ID: {offender.OffenderId}, Ім'я: {offender.FirstName}, Прізвище: {offender.LastName}, Тип порушення: {offender.ViolationType}, Поліцейський: {offender.PolicemanFullName}");
        }
    }

    private static string FormatOffenders(ICollection<Offender> offenders)
    {
        if (offenders == null || offenders.Count == 0)
        {
            return "Немає правопорушників";
        }

        return string.Join(", ", offenders.Select(o => $"{o.FirstName} {o.LastName} ({o.ViolationType})"));
    }
}