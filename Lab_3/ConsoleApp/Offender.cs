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

