using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_05_MVVM
{
    public partial class MainWindowVM : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        public string? firstName;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        public string? lastName;

        [ObservableProperty]
        public int age;

        public MainWindowVM()
        {
            Age = 20;
        }

        public string FullName { 
            get {
                return $"{firstName} {lastName}";
            } 
        }
        [RelayCommand]
        public void IncreaseAge()
        {
            Age += 5;
        }
        [RelayCommand]

        public void DecreaseAge()
        {
            Age -= 5;
        }
    }
}
