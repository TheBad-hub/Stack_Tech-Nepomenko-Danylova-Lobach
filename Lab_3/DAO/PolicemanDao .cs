using Microsoft.EntityFrameworkCore;

public class PolicemanDao : IGenericDao<Policeman>
{
    private readonly PoliceContext _context;

    public PolicemanDao(PoliceContext context)
    {
        _context = context;
    }

    public void Add(Policeman policeman)
    {
        _context.Policemen.Add(policeman);
        _context.SaveChanges();
    }

    public void Update(Policeman policeman)
    {
        _context.Policemen.Update(policeman);
        _context.SaveChanges();
    }

    public void Delete(Policeman policeman)
    {
        _context.Policemen.Remove(policeman);
        _context.SaveChanges();
    }

    public Policeman? GetById(int id)
    {
        return _context.Policemen
                       .Include(p => p.Offenders)
                       .FirstOrDefault(p => p.PolicemanId == id);
    }

    public List<Policeman> GetAll()
    {
        return _context.Policemen
                       .Include(p => p.Offenders)
                       .ToList();
    }

    public Policeman? GetByIdWithOffenders(int id)
    {
        return _context.Policemen
                       .Include(p => p.Offenders) 
                       .FirstOrDefault(p => p.PolicemanId == id);
    }
}
