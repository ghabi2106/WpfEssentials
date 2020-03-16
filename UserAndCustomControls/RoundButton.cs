using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace UserAndCustomControls {
    public class RoundButton : Button {
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof (CornerRadius), typeof (RoundButton),
                new PropertyMetadata(default(CornerRadius)));

        public CornerRadius CornerRadius {
            get { return (CornerRadius) GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        static RoundButton() {
            DefaultStyleKeyProperty.OverrideMetadata(typeof (RoundButton),
                new FrameworkPropertyMetadata(typeof (RoundButton)));
        }
    }
}