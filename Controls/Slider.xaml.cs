using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Controls {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            SliderValue.Text = e.NewValue.ToString(CultureInfo.InvariantCulture);
        }

        private void OnValueChanged2(object sender, RoutedPropertyChangedEventArgs<double> e) {
            SliderValue2.Text = e.NewValue.ToString(CultureInfo.InvariantCulture);
        }        
    }
}