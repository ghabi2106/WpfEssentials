using System.Collections.ObjectModel;
using System.Windows;
using DataBinding;

namespace StylesTemplatesSkinsThemes {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public ObservableCollection<Craftsman> Craftsmen { get; private set; }

        public MainWindow() {
            Craftsmen = new ObservableCollection<Craftsman>();
            InitializeComponent();

            Default.IsChecked = true;
        }

        private void Exit_OnClick(object sender, RoutedEventArgs e) {
            Application.Current.Dispatcher.InvokeShutdown();
        }

        private void AddCraftsman_OnClick(object sender, RoutedEventArgs e) {
            AddCraftsman addCraftsmanWindow = new AddCraftsman(Craftsmen);
            addCraftsmanWindow.ShowDialog();
        }

        private void Green_OnChecked(object sender, RoutedEventArgs e) {
            SkinManager.SetSkin(AppSkin.Green);
        }

        private void Default_OnChecked(object sender, RoutedEventArgs e) {
            SkinManager.SetSkin(AppSkin.Default);
        }
    }
}