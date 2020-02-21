using DataLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Services
    {
        public Services(AppDbContext appDbContext)
        {
            EmployeeService = new EmployeeService(appDbContext);
            
        }

        public EmployeeService EmployeeService { get; set;  }
    }
}
