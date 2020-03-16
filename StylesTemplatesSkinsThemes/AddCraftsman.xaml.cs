using System;
using System.Collections.ObjectModel;
using System.Windows;
using DataBinding;

namespace StylesTemplatesSkinsThemes {
    /// <summary>
    /// Interaction logic for AddCraftsman.xaml
    /// </summary>
    public partial class AddCraftsman : Window {
        private readonly ObservableCollection<Craftsman> craftsmen;

        public AddCraftsman(ObservableCollection<Craftsman> craftsmen) {
            this.craftsmen = craftsmen;
            InitializeComponent();
        }

        private void Ok_OnClick(object sender, RoutedEventArgs e) {
            craftsmen.Add(new Craftsman() {Age = int.Parse(CraftsmanInput.Age), LastName = CraftsmanInput.Lastname, Name = CraftsmanInput.Name});
            Close();
        }

        private void Cancel_OnClick(object sender, RoutedEventArgs e) {
            Close();
        }
    }
}