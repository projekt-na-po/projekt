using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Flight_control
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void Ikonka_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var obrazek1 = new Uri("pack://application:,,,/mapa_rzek_polski.jpg");
            var image = new BitmapImage(obrazek1);
            this.Radar.Background = new ImageBrush(image);

        }

        private void Ikonka_2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var obrazek1 = new Uri("pack://application:,,,/niemcy-mapa-satelitarna.jpg");
            var image = new BitmapImage(obrazek1);
            this.Radar.Background = new ImageBrush(image);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
