using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sometext.Models
{
    public class Person :BaseClass
    {

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; OnPropertyChanged(nameof(Name)); }
		}


	}
}
