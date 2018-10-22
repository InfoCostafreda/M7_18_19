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

namespace WpfApp6
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// TAULES
        /// </summary>
        // taula d'enters amb inicialització
        int[] primers = { 1, 2, 3, 5, 7,11, 101 };

        // taules d'strings
        string[] alumnes = { "Marc", "Jordi", "Oriol","Joel","Arnau A.","Arnau V.","Joan M.", "Ivan","Pedro" };

        // creació d'una taula indicant la seva dimensió
        // el valor per defecte en aquest cas es 0
        byte[] edat = new byte[9];

        public MainWindow()
        {
            InitializeComponent();

            //Alumne inicial
            Random rnd = new Random(DateTime.Now.Millisecond);
            txtBlockMostra.Text = alumnes[rnd.Next(0,alumnes.Length)];

        }

        private void Button_Click_MostraAlumnes(object sender, RoutedEventArgs e)
        {
            //////
            ///FOR
            ///
            txtBlockMostra.Text = "";
            for (int i = 0; i < alumnes.Length; i++)
            {
                txtBlockMostra.Text += alumnes[i] +" ";
            }
        }
        private void Button_Click_MostraPrimers(object sender, RoutedEventArgs e)
        {
            //////
            ///FOR EACH
            ///
            txtBlockMostra.Text = "";
            foreach (int t in primers)
            {
                txtBlockMostra.Text += $"{t}, ";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
