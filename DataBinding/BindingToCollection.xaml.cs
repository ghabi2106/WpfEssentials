using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DataBinding {
    /// <summary>
    /// Interaction logic for BindingToCollection.xaml
    /// </summary>
    public partial class BindingToCollection : Window {
        public ObservableCollection<Craftsman> Craftsmen { get; private set; }

        public BindingToCollection() {
            Craftsmen = new ObservableCollection<Craftsman>() {
                new Craftsman() {Age = 45, LastName = "Seemann", Name = "Mark", PicturePath = "Images/Seemann.jpeg"},
                new Craftsman() {Age = 60, LastName = "Martin", Name = "Robert", PicturePath = "Images/UncleBob.jpg"},
            };
            InitializeComponent();
        }

        private void AddCraftsman_OnClick(object sender, RoutedEventArgs e) {
            Task.Run(() => {
                Craftsmen.Add(new Craftsman() {
                    Age = 60,
                    LastName = "Fowler",
                    Name = "Martin",
                    PicturePath = "Images/FowlerMartin.jpg"
                });
            });
        }
    }
}