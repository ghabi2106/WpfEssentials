using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Layout {
    public class HorizontalStackPanel : Panel {
        protected override Size MeasureOverride(Size availableSize) {
            var size = new Size();

            foreach (UIElement child in this.InternalChildren) {
                child.Measure(availableSize);
                size.Width += child.DesiredSize.Width;
                size.Height = size.Height > child.DesiredSize.Height ? size.Height : child.DesiredSize.Height;
            }
            return size;
        }

        protected override Size ArrangeOverride(Size finalSize) {
            var location = new Point();

            foreach (UIElement child in this.InternalChildren) {
                child.Arrange(new Rect(location, child.DesiredSize));
                location.X += child.DesiredSize.Width;
            }
            return finalSize;
        }
    }
}