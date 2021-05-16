using System.Collections.Generic;
using System;

namespace CalenderPlanner.Domain.Interfaces
{
  public interface IRepo<T> where T : class
  {
    IEnumerable<T> Create(Func<T, bool> filter);
    bool Read(T entry);
    T Update();
    bool Delete();
  }
}