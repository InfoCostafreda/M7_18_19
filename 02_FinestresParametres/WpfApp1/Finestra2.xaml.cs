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
using System.Windows.Shapes;
using System.IO;

namespace AppStartup
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Finestra2 : Window
    {
        public Finestra2()
        {
            InitializeComponent();
        }
        public void ObreFitxer(string fitxer)
        {
            try
            {   // Obrim el fitxer emprant un stream reader.
                StreamReader sr = new StreamReader(fitxer);
 
                String contingut = sr.ReadToEnd();
                this.txtbloc1.Text = contingut;
                 

                
               
            }
            catch (Exception e)
            {
                Console.WriteLine("El fitxer no es pot llegir:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
