using System;
using CalenderPlanner.Domain.Abstracts;

namespace CalenderPlanner.Domain.Models
{
    public class Event : Entity
    {
        public string Discription { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        
    }
}