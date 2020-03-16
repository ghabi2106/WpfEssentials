using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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

namespace Resources {
    /// <summary>
    /// Interaction logic for BinaryResources.xaml
    /// </summary>
    public partial class BinaryResources : Window {
        public BinaryResources() {
            InitializeComponent();

            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "Resources.Seemann.jpeg";

            Stream stream = assembly.GetManifestResourceStream(resourceName);
            byte[] result = new byte[stream.Length];
            stream.Read(result, 0, result.Length);

            CraftsmanPicture.Source = LoadImage(result);
        }

        private static BitmapImage LoadImage(byte[] imageData) {
            if (imageData == null || imageData.Length == 0) {
                return null;
            }
            var image = new BitmapImage();
            using (var mem = new MemoryStream(imageData)) {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }
    }
}