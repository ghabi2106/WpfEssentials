using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Controls {
    /// <summary>
    /// Interaction logic for ProgressBar.xaml
    /// </summary>
    public partial class ProgressBar : Window {
        public ProgressBar() {
            InitializeComponent();
        }


        private void StartLongRunningTask_OnClick(object sender, RoutedEventArgs e) {
            Task.Run(() => {
                for (int i = 0; i < 10; i++) {
                    Thread.Sleep(150);
                    Application.Current.Dispatcher.Invoke(() => { Progress.Value += 10; });
                }
            });
        }
    }
}