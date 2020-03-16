using BusinessLayer;
using GUI_WPF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;

namespace GUI_WPF.ViewModels
{
   public class UpdateEmployeeViewModel :INotifyPropertyChanged
    {
		Services Services { get; set; }
		public UpdateEmployeeViewModel(Services services,EmployeeModel employeeModel)
		{
			Services = services;
			EmployeeModel = employeeModel;
		}
		private EmployeeModel _employeeModel;

		public EmployeeModel EmployeeModel
		{
			get { return _employeeModel; }
			set { _employeeModel = value; Changed(); }
		}

		public event PropertyChangedEventHandler PropertyChanged;
		public void Changed([CallerMemberName] String propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public void Update()
		{
			MessageBox.Show("Du har uppdaterat din profil");
			EmployeeModel.UpdateEmployee(Services);
		}

	}
}
