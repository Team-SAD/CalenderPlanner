using CalenderPlanner.Domain.Interfaces;
using System.Collections.Generic;
using CalenderPlanner.Domain.Models;
using System;


namespace CalenderPlanner.Storing.Repos
{
  public class CustomerRepo : IRepo<Customer>
  {
    private readonly CPContext _context;

    public CustomerRepo(CPContext context)
    {
      _context = context;
    }

    public IEnumerable<Customer> Create(Func<Customer, bool> filter)
    {
      throw new System.NotImplementedException();
    }

    public bool Read(Customer entry)
    {
      _context.Customers.Add(entry);
      return true;
    }

    public Customer Update()
    {
      throw new System.NotImplementedException();
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }
  }
}