public class Policeman
{
    public int PolicemanId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string BadgeNumber { get; set; }
    public virtual ICollection<Offender> Offenders { get; set; }
}
