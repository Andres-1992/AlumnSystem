using BusinessEntities.Enums;
using DataLayer.Contexts.Junction;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Models
{

    public class Event
    {
        public int EventId { get; private set; }
        public string Title { get;  set; }
        public string Description {  get;  set; }
        public DateTime StartDate { get;  set; }
        public DateTime EndDate { get;  set; }
        public DateTime LastApplyingDate { get;  set; }


        public int EmployeeId { get; private set; }
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
