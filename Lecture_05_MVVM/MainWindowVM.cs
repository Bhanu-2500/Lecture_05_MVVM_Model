using CommunityToolkit.Mvvm.ComponentModel;
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

        

        public string FullName { 
            get {
                return $"{firstName} {lastName}";
            } 
        }

        public void IncreaseAge()
        {
            age += 5;
        }
        public void DecreaseAge()
        {
            age -= 5;
        }
    }
}
