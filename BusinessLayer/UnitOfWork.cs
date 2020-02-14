using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;
namespace BusinessLayer
{
    public class UnitOfWork
    {
        
          public  EmployeeRepository empr = new EmployeeRepository();
           public AlumnRepository ar = new AlumnRepository();
           public EventRepository er = new EventRepository();


    }
    
}
