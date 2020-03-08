using AutoMapper;
using BusinessEntities.Models;
using BusinessLayer;
using DataLayer;
using DataLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GUI_WPF.Models
{
   public class EmployeeModel:Person
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

		internal EmployeeModel GetLoggedInEmployee(string idInput, string password, Services services)
        {
			Employee employee = services.LogInServices.LogInEmployee(idInput, services.BusinessManager.Encrypt(password));
			if (employee != null)
			{
			 	EmployeeModel employeeModel = mapper.Map<Employee, EmployeeModel>(employee);
				return employeeModel;
			}
			else return null;
		}
	}
}
