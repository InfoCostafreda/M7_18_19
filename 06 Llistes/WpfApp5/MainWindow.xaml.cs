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
    /// 


    public partial class MainWindow : Window
    {





        /*
            * 
            * 
            Llistes dinàmiques 

            Les llistes dinàmiques són estructures de dades que es van 
            fent grans a mesura que es necessita. //Gran difèrència de les taules 
            Per tant no cal que donem una mida inicial a la llista.
            La llista va creixent dinàmicament a mesura que necessita afegir més elements.

            .NET ens proporciona els tipus de dades dinàmics més usuals, 

                List    //Llista
                Queue   //FIFO 
                Stack   // LIFO
                Dictionary  //Taula associativa


            LIST - LLISTA


            Inicialització
            -----------------

            La sintaxi d'una llista dinàmica bàsica és:

            List<[tipus de dades]> = new List<tipus de dades]();

            Creació duna llista dinàmica
            */
            List<string> alumnes = new List<string>();

      


        public MainWindow()
        {
            InitializeComponent();

               /*
              Afegir elements
                ----------------
           */

            // Afegir elements a la llista
            alumnes.Add("Oriol");
            alumnes.Add("Marc");
            alumnes.Add("Arnau");
            alumnes.Add("Jordi");
            alumnes.Add("Arnau");

            // Accés per índex
            alumnes[2] = "Joan Marc";


            alumnes.Add("Arnau");
            alumnes.Add("Maria");

            //Atualitzem el llistat
            Mostra_Llista();


        }

        private void Mostra_Llista()
        {
            /*

             * Recorreguts
             --------------
            */
            // Recorregut per índex
            string noms = "";
            noms += "Primer Recorregut\n";
            for (int n=0;n<alumnes.Count;n++)
            {
    	        noms += $" - {alumnes[n]} \n";
            }

            

            noms += "Segon Recorregut\n";
            // Recorregut amb foreach
            foreach ( string p in alumnes )
            {
    	        noms += $" - {p} \n";
            }
            
            txtBMostrar.Text = noms;
            

        }

        private void Afegeix_Click(object sender, RoutedEventArgs e)
        {
            //afegim a la llista l'indicat al txtNouElement
            alumnes.Add(txtNouElement.Text);

            //Atualitzem el llistat
            Mostra_Llista();


        }

        private void Elimina_Click(object sender, RoutedEventArgs e)
        {
            /*
            Eliminar elements
            -------------------
            */

            // Eliminació d'un element de la llista
            // alumnes.Remove(2); // esborra l'element amb índex 2 ( el tercer )

            //Elimina la primera ocurrència de l'element a eliminar.
            // per exemple alumnes.Remove("Arnau");



            // i reindexa els posteriors

            //ara eliminarem el que indica el txtBox txtTreuElement
            alumnes.Remove(txtTreuElement.Text);

            //Atualitzem el llistat
            Mostra_Llista();

        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {

            // esborra l'element de la posició indicada
            alumnes.RemoveAt(2);
            // i reindexa els posteriors


            
        }

        private void Cerca_Click(object sender, RoutedEventArgs e)
        {
            // Cerca d'elements

            /* Exemple de cerques
            bool MariaFound = alumnes.Contains("Maria"); // mariaFound és true
            bool mariaFound = alumnes.Contains("maria"); // mariaFound és false
            bool kkFound = alumnes.Contains("kk"); //kkFound false

            String resultat = "Maria "+MariaFound.ToString() + "kk "+kkFound.ToString();
            */

            bool cerca = alumnes.Contains(txtCompara.Text);
            if(cerca)
            {
                txtCompara.Text = "Trobat";
            }
            else
            {
                txtCompara.Text = "No trobat";
            }
            
            
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            alumnes.RemoveRange(0, 2);
        }
    }
}





