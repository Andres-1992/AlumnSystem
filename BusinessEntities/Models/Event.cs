using DataLayer.Contexts.Junction;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Models
{
    public class Event
    {
        public int EventId { get; private set; }
        public string Title { get; private set; }
        public string Description {  get; private set; }
        public DateTimeOffset StartDate { get; private set; }
        public DateTimeOffset EndDate { get; private set; }
        public DateTimeOffset LastApplyingDate { get; private set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; private set; }

        public ICollection<AlumnEvent> AlumnEvents { get; private set; }
        public Event()
        {
            //  Dummy så EF fattar
        }

        public Event(string title, string description, DateTime startdate, DateTime enddate,  DateTime lastapplyingdate, int employeeid)
        {
            Title = title;
            Description = description;
            StartDate = startdate;
            EndDate = enddate;
            LastApplyingDate = lastapplyingdate;
            EmployeeId = employeeid;
        }
    }
}
