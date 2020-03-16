using System.Windows;
using System.Windows.Controls;

namespace ItemsControls {
    /// <summary>
    /// Interaction logic for ListBox.xaml
    /// </summary>
    public partial class ListBox : Window {
        public ListBox() {
            InitializeComponent();
        }

        private void Box_OnSelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (e.AddedItems.Count > 0) {
                var box = (ComboBox) sender;
                //                box.Selected
                //                object selected = e.AddedItems[0];
                //                var boxItem = (ComboBoxItem)selected;
                //                var boxDt = (DateTime)selected;
                //                Console.WriteLine(boxDt);
            }
        }        
    }
}