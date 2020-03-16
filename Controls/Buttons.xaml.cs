using System.Diagnostics;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace Controls {
    /// <summary>
    /// Interaction logic for Buttons.xaml
    /// </summary>
    public partial class Buttons : Window {
        public Buttons() {
            InitializeComponent();            
        }

        private void OrdinaryButton_OnClick(object sender, RoutedEventArgs e) {
            Debug.WriteLine("Ordinary Button");
        }

        private void RepeatButton_OnClick(object sender, RoutedEventArgs e) {
            Debug.WriteLine("Repeat Button");
        }

        private void ToggleButton_OnClick(object sender, RoutedEventArgs e) {
            Debug.WriteLine("Toggle Button");
        }

        #region Checked-Unchecked-Indeterminate
        private void ToggleButton_Checked(object sender, RoutedEventArgs e) {
            var toggleButton = (ToggleButton) sender;
            Debug.WriteLine("{0} is checked. Now IsChecked={1}", toggleButton.Name, toggleButton.IsChecked);
        }

        private void ToggleButton_Unchecked(object sender, RoutedEventArgs e) {
            var toggleButton = (ToggleButton) sender;
            Debug.WriteLine("{0} is unchecked. Now IsChecked={1}", toggleButton.Name, toggleButton.IsChecked);
        }

        private void ToggleButton_Indeterminate(object sender, RoutedEventArgs e) {
            var toggleButton = (ToggleButton)sender;
            Debug.WriteLine("{0} is in indeterminate state. Now IsChecked={1}", toggleButton.Name, toggleButton.IsChecked);
        }
        #endregion
    }
}