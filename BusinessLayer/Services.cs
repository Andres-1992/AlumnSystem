using DataLayer;
using DataLayer.Contexts;

namespace BusinessLayer
{
    public class Services
    {
        public Services(AppDbContext appDbContext, UnitOfWork unitOfWork)
        {
            EmployeeServices = new EmployeeService(appDbContext, unitOfWork);
            AlumnServices = new AlumnService(appDbContext, unitOfWork);
            LogInServices = new LogInService(appDbContext, unitOfWork);
            BusinessManager = new BusinessManager(appDbContext, unitOfWork);
        }

        public IEmployeeService EmployeeServices { get; private set; }
        public IAlumnService AlumnServices { get; private set; }
        public IBusinessManager BusinessManager { get; private set; }
        public ILogInService LogInServices { get; private set; }
    }
}
