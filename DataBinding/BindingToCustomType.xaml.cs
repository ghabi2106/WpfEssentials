using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace DataBinding {
    /// <summary>
    /// Interaction logic for BindingToCustomType.xaml
    /// </summary>
    public partial class BindingToCustomType : Window {
        public Craftsman Craftsman { get; set; }

        public BindingToCustomType() {
            Craftsman = new Craftsman() {
                Age = 45,
                LastName = "Seemann",
                Name = "Mark",
                PicturePath = "Images/Seemann.jpeg"
            };

            InitializeComponent();            
        }

        private void ChangeAge_OnClick(object sender, RoutedEventArgs e) {
            Craftsman.Age = 40;
        }
    }
}