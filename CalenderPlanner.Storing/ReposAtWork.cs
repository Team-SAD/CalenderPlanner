using CalenderPlanner.Storing.Repos;

namespace CalenderPlanner.Storing
{
  public class ReposAtWork
  {
    private readonly CPContext _context;
    public CustomerRepo Customers { get; set; }

    public ReposAtWork(CPContext context)
    {
      _context = context;

      Customers = new CustomerRepo(_context);
    }
    public void Save()
    {
      _context.SaveChanges();
    }
  }
}