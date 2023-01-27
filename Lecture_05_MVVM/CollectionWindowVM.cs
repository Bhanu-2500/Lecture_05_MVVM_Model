using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_05_MVVM
{
    public partial class CollectionWindowVM : ObservableObject
    {
        public List<Person> People { get; set; }
        public CollectionWindowVM()
        {
            People= new List<Person>() { 
                new Person(24,"Tom1","Brown1","1.png"),
                new Person(12,"Tom2","Brown2","2.png"),
                new Person(13,"Tom3","Brown3","3.png"),
                new Person(14,"Tom4","Brown4","4.png"),
                new Person(17,"Tom5","Brown5","5.png"),
                new Person(13,"Tom6","Brown6","6.png"),
                new Person(14,"Tom7","Brown7","7.png"),
                new Person(12,"Tom8","Brown8","8.png")
            };
        }
    }
}
