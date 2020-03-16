using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DataBinding.Annotations;

namespace DataBinding {
    public class Craftsman : INotifyPropertyChanged {
        private int age;
        public string Name { get; set; }
        public string LastName { get; set; }

        public int Age {
            get {                              
                return age;
            }
            set {              
                age = value; 
                OnPropertyChanged();
            }
        }

        public string PicturePath { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}