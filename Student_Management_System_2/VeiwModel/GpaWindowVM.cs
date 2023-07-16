using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Student_Management_System_2.Models;
using Student_Management_System_2.Views;

namespace Student_Management_System_2.VeiwModel
{
    public partial class GpaWindowVM : ObservableObject
    {

        public ICommand OpenUserWindowCommand { get; }
        private void OpenUserWindow()
        {

            UserWindow Window = new UserWindow();
            Window.Show();

        }



        [ObservableProperty]
        public ObservableCollection<Module> _modules;



        public GpaWindowVM()
        {

            OpenUserWindowCommand = new RelayCommand(OpenUserWindow);
            var db = new DataContext();
            var list = db.Modules.ToList();
            _modules = new ObservableCollection<Module>(list);

        }


    }
}


