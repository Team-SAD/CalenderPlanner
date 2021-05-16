using System.Collections.Generic;
using CalenderPlanner.Domain.Abstracts;

namespace CalenderPlanner.Domain.Models
{
  public class Customer : Entity
  {
    public string Name { get; set; }

    public override string ToString()
    {
      return $"{Name}";
    }
  }
}