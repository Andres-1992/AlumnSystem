using AutoMapper;
using BusinessEntities.Models;
using BusinessLayer;

namespace GUI_WPF.Models
{
    public class EmployeeModel : Person
    {

        public EmployeeModel()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Employee, EmployeeModel>();
            });
            mapper = config.CreateMapper();
        }
        IMapper mapper { get; set; }
        private string _signature;
        private int _employeeId;

        #region properties

        public int EmployeeId
        {
            get { return _employeeId; }
            set { _employeeId = value; }
        }

        public string Signature
        {
            get { return _signature; }
            set { _signature = value; }
        }
        #endregion


        internal EmployeeModel GetLoggedInEmployee(string idInput, string password, Services services)
        {
            Employee employee = services.LogInServices.LogInEmployee(idInput, services.LogInServices.Encrypt(password));
            if (employee != null)
            {
                EmployeeModel employeeModel = mapper.Map<Employee, EmployeeModel>(employee);
                return employeeModel;
            }
            else return null;
        }

        internal Employee GetEmployee(Services services)
        {
            return services.GetServices.GetEmployee(EmployeeId);
        }

        internal void UpdateEmployee(Services services)
        {
            Employee employee = GetEmployee(services);
            employee.Name = Name;
            employee.Email = Email;
            employee.Phonenumber = Phonenumber;

            services.UpdateServices.UpdateEmployee(employee);
        }
    }
}
