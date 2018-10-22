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

namespace WpfApp5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /*
             *
                Taules
                C# ens permet definir taules estàtiques:

                // exemple de taula amb inicialització
                int[] numeros= { 1, 6, 7, 10 };

                // podem fer taules de tipus més complexes, com cadenes
                string[] persones = { "Maria", "Berta", "Joan" };

                // creació d'una taula indicant dimensions, que s'omplirà
                // amb el valor per defecte del tipus de dades ( 0 en aquest cas )
                double[] temperatures = new double[10];

                Iteradors
                for

                for (initializer; condition; iterator): statement(s)

                Funciona igual que a C. Iterador clàssic:

                int suma = 0;
                int i ;
                for ( i = 0; i < 100; i++)
                {
                suma += i;
                }

                Iterador amb declaració incorporada:

                int suma = 0;
                for (int i = 0; i < 100; i++)
                {
                suma += i;
                }

                while i do while

                Igual que a C:

                while(condition) statement(s);

                do { statement(s) } while( condition );

                foreach

                Permet automatitzar el recorregut complet sobre una taula o llista.

                Recorregut sobre taules:

                        int[] numeros= { 1, 6, 7, 10 };
		                string resultat = "";
                        foreach( int t in numeros)
                        {
                            resultat += $" - {t}\n";
                        }
             * 
             * */

        }
        private void Condicional_Simple()
        {
            if(RadioVermell.IsChecked==true)
            {
                Form1.Background = Brushes.Red; 
            }
            if (RadioVerd.IsChecked == true)
            {
                Form1.Background = Brushes.Green;
            }
            if (RadioVioleta.IsChecked == true)
            {
                Form1.Background = Brushes.Violet;
            }

        }
        private void Condicional_Compacte()
        {
            if (RadioVermell.IsChecked == true)Form1.Background = Brushes.Red;

            if (RadioVerd.IsChecked == true) Form1.Background = Brushes.Green;

            if (RadioVioleta.IsChecked == true) Form1.Background = Brushes.Violet;


        }
        private void Condicional_IfElse()
        {
            if (RadioVermell.IsChecked == true)
            {
                Form1.Background = Brushes.Red;
            }
            else if (RadioVerd.IsChecked == true)
            {
                Form1.Background = Brushes.Green;
            }
            else 
            {
                Form1.Background = Brushes.Violet;
            }

        }
        private void Condicional_Switch()
        {

            //switch
            // És igual que a C, però amb algunes peculiaritats:
            // ens força a posar break (evita errors )
            //Pot funcionar amb strings !!

            String color;

            color = txtBoxColor.Text;
                
            switch (color)
            {
                case "1":
                    Form1.Background = Brushes.Red;
                    break;
                case "2":
                    Form1.Background = Brushes.Green;
                    break;
                case "3":
                    Form1.Background = Brushes.Violet;
                    break;
         
            } 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //condicionals simples
            if(RadioSimple.IsChecked==true)
            {
                Condicional_Simple();
            }
            else if(RadioCompacte.IsChecked==true)
            {
                Condicional_Compacte();
            }
            else if(RadioIfiElse.IsChecked==true)
            {
                Condicional_IfElse();
            }
            else if(RadioSwitch.IsChecked==true)
            {
                Condicional_Switch();
            }
        

          


        }

        private void chkCanviaColor(object sender, RoutedEventArgs e)
        {
            RadioButton rb=sender as RadioButton;
            //condicionals IF ELSE
            if (rb.Name.Equals("RadioVermell"))
            {
                txtBoxColor.Text = "1";
            }
            else if (rb.Name.Equals("RadioVerd"))
            {
                txtBoxColor.Text = "2";
            }
            else if (rb.Name.Equals("RadioVioleta"))
            {
                txtBoxColor.Text = "3";
            }
            else { txtBoxColor.Text = "No s'ha seleccionat res"; }

        }

        private void txtBox_CanviaText(object sender, TextChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            int num;
            num = System.Int16.Parse(tb.Text);

           /// switch amb enters
            switch (num)
            {
                case 1:
                    RadioVermell.IsChecked = true;
                    break;
                case 2:
                    RadioVerd.IsChecked = true;
                    break;
                case 3:
                    RadioVioleta.IsChecked = true;
                    break;

            }
        }
    }
}
