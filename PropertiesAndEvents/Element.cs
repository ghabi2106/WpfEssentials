using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PropertiesAndEvents {
    public class Element : DependencyObject {
        public static readonly DependencyProperty SecurityIdProperty =
            DependencyProperty.RegisterAttached("SecurityId", typeof (string), typeof (Element),
                                                new PropertyMetadata(""));
      
        public static string GetSecurityId(DependencyObject d) {
            return (string) d.GetValue(SecurityIdProperty);
        }

        public static void SetSecurityId(DependencyObject d, string value) {
            d.SetValue(SecurityIdProperty, value);
        }

        public static readonly DependencyProperty SizeProperty =
            DependencyProperty.Register("Size", typeof (Size), typeof (Element), 
                                        new UIPropertyMetadata(new Size(0, 0)));

        public Size Size {
            get { return (Size) GetValue(SizeProperty); }
            set { SetValue(SizeProperty, value); }
        }
    }
}