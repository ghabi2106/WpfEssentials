using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace PropertiesAndEvents {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();

//            this.MouseDown += OnMouseDown;
//            MyBorder.MouseDown += OnMouseDown;
//            BlueStackPanel.MouseDown += OnMouseDown;
//            GreenRectangle.MouseDown += OnMouseDown;
//
//
//            this.MouseEnter += OnMouseEnter;
//            MyBorder.MouseEnter += OnMouseEnter;
//            BlueStackPanel.MouseEnter += OnMouseEnter;
//            GreenRectangle.MouseEnter += OnMouseEnter;

            this.PreviewMouseDown += PreviewOnMouseDown;
            MyBorder.PreviewMouseDown += PreviewOnMouseDown;
            BlueStackPanel.PreviewMouseDown += PreviewOnMouseDown;
            GreenRectangle.PreviewMouseDown += PreviewOnMouseDown;
        }


        private void OnMouseEnter(object sender, MouseEventArgs e) {
            LogMouseDownEvent(sender, "MouseEnter");
        }

        private void OnMouseDown(object sender, MouseButtonEventArgs mouseButtonEventArgs) {
            LogMouseDownEvent(sender, "MouseDown");

//            Debug.WriteLine("OriginalSource:{0}", mouseButtonEventArgs.OriginalSource);
//            Debug.WriteLine("Source:{0}", mouseButtonEventArgs.Source);
//
//            var rect = mouseButtonEventArgs.Source as Rectangle;
//            if (rect != null)
//            {
//                rect.Fill = Brushes.DarkOrchid;
//            }
//            if (sender is StackPanel)
//            {
//                mouseButtonEventArgs.Handled = true;
//            }

        }

        private void PreviewOnMouseDown(object sender, MouseButtonEventArgs e) {
            LogMouseDownEvent(sender, "PreviewMouseDown");
        }

        private void LogMouseDownEvent(object sender, string eventName) {
            Debug.WriteLine("{0} fired on:{1}", eventName, sender);
        }
    }
}