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

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 
    

    public partial class MainWindow : Window
    {
        int imatge;

        public MainWindow()
        {
            InitializeComponent();
            imatge = 0;
        }

        private void CanviaIcona(object sender, RoutedEventArgs e)
        {
            if (imatge == 0)
            {
                Uri iconUri = new Uri("pack://application:,,,/paca.ico", UriKind.RelativeOrAbsolute);
                this.Icon = BitmapFrame.Create(iconUri);
                imatge = 1;
            }
            else if (imatge == 1)
            {
                Uri iconUri = new Uri("pack://application:,,,/fan.ico", UriKind.RelativeOrAbsolute);
                this.Icon = BitmapFrame.Create(iconUri);
                imatge = 2;
            }
            else if (imatge == 2)
            {
                Uri iconUri = new Uri("pack://application:,,,/pac.ico", UriKind.RelativeOrAbsolute);
                this.Icon = BitmapFrame.Create(iconUri);
                imatge = 0;
            }

        }
    }
}
