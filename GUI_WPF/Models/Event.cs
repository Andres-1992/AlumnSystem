using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using BusinessLayer;
using DataLayer.Contexts;
using DataLayer;
using System.Threading.Channels;

namespace GUI_WPF.Models
{
	public class Event : INotifyPropertyChanged
	{
		public Event()
		{
			appDbContext = new AppDbContext();
			unitOfWork = new UnitOfWork(appDbContext);
			services = new Services(appDbContext, unitOfWork);
		}
		AppDbContext appDbContext { get; set; }
		UnitOfWork unitOfWork { get; set; }
		Services services {get;set; }
		private int eventId;

		public int EventId
		{
			get { return eventId; }
			set { eventId = value; }
		}

		private string title;

		public string Title
		{
			get { return title; }
			set { title = value; }
		}
		private string description;

		public string Description
		{
			get { return description; }
			set { description = value; }

		}
		private DateTime startdate;

		public DateTime StartDate
		{
			get { return startdate; }
			set { startdate = value; }
		}
		private DateTime enddate;

		public DateTime EndDate
		{
			get { return enddate; }
			set { enddate = value; }
		}
		private DateTime lastapplyingdate;

		public DateTime LastApplyingDate
		{
			get { return lastapplyingdate; }
			set { lastapplyingdate = value; }
		}

		public void Delete()
		{
			services.EmployeeServices.RemoveEvent(this.EventId);
		}

		private int employeeId;
					
		public int EmployeeId
		{
			get { return employeeId; }
			set { employeeId = value; }
		}


		public event PropertyChangedEventHandler PropertyChanged;
				public void Changed([CallerMemberName] String propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public void SaveEvent()
		{
			BusinessEntities.Models.Event events = new BusinessEntities.Models.Event()
			{
				Title = this.Title,
				Description = this.Description,
				StartDate = this.StartDate,
				EndDate = this.EndDate,
				LastApplyingDate = this.LastApplyingDate,
				EmployeeId = 1

			};
			services.EmployeeServices.AddEvent(events);

		}

		public ObservableCollection<Event> GetEvents()
		{
			ObservableCollection<Event> x = new ObservableCollection<Event>();
			foreach (var item in services.BusinessManager.GetEvent())
			{
				Event events = new Event()
				{
					Title = item.Title,
					Description = item.Description,
					StartDate = item.StartDate,
					EndDate = item.EndDate,
					LastApplyingDate = item.LastApplyingDate,
					EventId = item.EventId

				};
				x.Add(events);
							}
			return x;
		}
	}
}
