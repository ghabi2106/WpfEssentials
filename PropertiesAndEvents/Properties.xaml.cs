using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PropertiesAndEvents {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void CheckId_OnClick(object sender, RoutedEventArgs e) {
            foreach (UIElement child in Panel.Children) {
                var id = Element.GetSecurityId(child);                
                if (id == "a1") {
                    // do something significant here
                    child.Visibility = Visibility.Collapsed;
                }
            }
        }
    }
}