using ProjetAPIWS2023.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAPIWS2023.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand MapViewCommand { get; set; }
        public RelayCommand ListCentreViewCommand { get; set; }


        public HomeViewModel HomeVm { get; set; }
        public MapViewModel MapVm { get; set; }
        public ListCentreViewModel ListCentreVm { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; 
                OnPropertyChanged();
            }
        }

        public MainViewModel() { 

            HomeVm = new HomeViewModel();
            MapVm = new MapViewModel();
            ListCentreVm = new ListCentreViewModel();

            CurrentView = HomeVm;

            MapViewCommand = new RelayCommand(o =>{
                CurrentView = MapVm;
            });

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVm;
            });

            ListCentreViewCommand = new RelayCommand(o => 
            { 
                CurrentView = ListCentreVm;
                
            });
        }
    }
}
