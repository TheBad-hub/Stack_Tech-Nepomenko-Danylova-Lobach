using Microsoft.EntityFrameworkCore;

public class OffenderDao : IGenericDao<Offender>
{
    private readonly PoliceContext _context;

    public OffenderDao(PoliceContext context)
    {
        _context = context;
    }

    public void Add(Offender offender)
    {
        _context.Offenders.Add(offender);
        _context.SaveChanges();
    }

    public void Update(Offender offender)
    {
        _context.Offenders.Update(offender);
        _context.SaveChanges();
    }

    public void Delete(Offender offender)
    {
        _context.Offenders.Remove(offender);
        _context.SaveChanges();
    }

    public Offender? GetById(int id)
    {
        return _context.Offenders
                       .Include(o => o.Policeman)
                       .FirstOrDefault(o => o.OffenderId == id);
    }

    public List<Offender> GetAll()
    {
        return _context.Offenders
                       .Include(o => o.Policeman)
                       .ToList();
    }
}
