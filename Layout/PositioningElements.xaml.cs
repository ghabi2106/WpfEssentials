using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace Layout {
    /// <summary>
    /// Interaction logic for PositioningElements.xaml
    /// </summary>
    public partial class PositioningElements : Window {
        public PositioningElements() {
            InitializeComponent();
            LayoutUpdated += OnLayoutUpdated;
        }

        private void OnLayoutUpdated(object sender, EventArgs eventArgs) {
//            Size.Text = string.Format("Default Width:{0},\nActual Width:{1}",
//                                      Button.Width.ToString(CultureInfo.InvariantCulture),
//                                      Button.ActualWidth.ToString(CultureInfo.InvariantCulture));
        }
    }
}