using System;
using System.Windows;

namespace WpfEssentials {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            Window win = new MainWindow();
            win.Title = "MainWindow";
            win.Height = 350;
            win.Width = 525;

//            win.Activated += WinOnActivated;
        }

//        private void WinOnActivated(object sender, EventArgs eventArgs) {
//            
//        }
        private void MainWindow_OnActivated(object sender, EventArgs e) {
            throw new NotImplementedException();
        }
    }
}