using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace ApplicationModel {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void ThrowException() {
            throw new Exception();
        }

        private void Start_OnClick(object sender, RoutedEventArgs e) {
            Task.Run(() => {
                throw new Exception();
            });
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}