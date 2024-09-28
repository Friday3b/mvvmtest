using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using sometext.Commands;
using sometext.Models;
using sometext.Commands;
using Newtonsoft.Json;
using System.IO;

namespace sometext.ModelViews
{
    public class PersonViewModel : ViewModelBase
    {



        public ObservableCollection<string> Names { get; set; }

        public string NewName { get; set; }
        public string SelectedName { get; set; }

        public ICommand AddNameCommand { get; set; }
        public ICommand DeleteNameCommand { get; set; }
      

        public PersonViewModel()
        {

            Names = new ObservableCollection<string>();
            AddNameCommand = new RelayCommand(AddName);
            DeleteNameCommand = new RelayCommand(DeleteName);
           

        }

       

        


        private void DeleteName(object parameter)
        {
            if (!string.IsNullOrWhiteSpace(SelectedName) && Names.Contains(SelectedName))
            {
                Names.Remove(SelectedName);
                SelectedName = null;
                OnPropertyChanged(nameof(SelectedName));

            }
        }

        private void AddName(object parameter)
        {

            if (!string.IsNullOrWhiteSpace(NewName))
            {
                Names.Add(NewName);
                NewName = string.Empty;
                OnPropertyChanged(nameof(NewName));
                
               
            }
        }





    }
}
