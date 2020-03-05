using BusinessEntities.Enums;
using BusinessEntities.Models;
using BusinessLayer;
using DataLayer;
using DataLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GUI_WPF.Models
{
    public class Alumn : Person
    {
		public Alumn()
		{
			appDbContext = new AppDbContext();
			unitOfWork = new UnitOfWork(appDbContext);
			services = new Services(appDbContext, unitOfWork);
		}
		AppDbContext appDbContext { get; set; }
		UnitOfWork unitOfWork { get; set; }
		Services services { get; set; }
		private int alumnId;

		public int AlumnId
		{
			get { return alumnId; }
			set { alumnId = value; }
		}
	
		private bool work;

		public bool Work
		{
			get { return work; }
			set { work = value; }
		}
		private Education education;

		public Education Education
		{
			get { return education; }
			set { education = value; }
		}


		public void SaveAlumn()
		{
			List<BusinessEntities.Models.Competence> x = new List<BusinessEntities.Models.Competence>();
			BusinessEntities.Models.Alumn alumn = new BusinessEntities.Models.Alumn(this.Name, this.Email, this.Phonenumber, this.Education, this.Password, this.Work);
			
			foreach(var item in Competences)
				{
				BusinessEntities.Models.Competence competence = new BusinessEntities.Models.Competence(item.Description, item.CompetenceLevel);
				x.Add(competence);

			}
			alumn.Competences = x;
			services.LogInServices.AddAlumn(alumn);

		}

		private ObservableCollection<Competence> competences;

		public ObservableCollection<Competence> Competences
		{
			get { return competences; }
			set { competences = value; }
		}




	}
}
