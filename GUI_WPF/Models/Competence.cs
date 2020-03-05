using BusinessEntities.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace GUI_WPF.Models
{
    public class Competence : INotifyPropertyChanged
    {
		public event PropertyChangedEventHandler PropertyChanged;
		public void Changed([CallerMemberName] String propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private string description;

		public string Description
		{
			get { return description; }
			set { description = value; }
		}
		private ObservableCollection<Alumn> alumn = new ObservableCollection<Alumn>();
		public ObservableCollection<Alumn> Alumn
		{
			get { return Alumn; }
			set
			{
				Alumn = value;
				Changed();
			}
		}
		private CompetenceLevel _competenceLevel;

		public CompetenceLevel CompetenceLevel
		{
			get { return _competenceLevel; }
			set { _competenceLevel = value; }
		}


	}
}
