using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace AppStartup
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {


        private void Inicia_Aplicacio(object sender, StartupEventArgs e)
        {
            Finestra2 fines2 = new Finestra2();
            
            int temps;
            temps = 5;
            
            while (temps>0)
            {
                Finestra1 fines1 = new Finestra1();
                fines1.txtblk1.Text = temps.ToString();
                fines1.Show();
                
                System.Threading.Thread.Sleep(1000);
                fines1.Close();
                temps--;
            }
            

            if (e.Args.Length == 1)
                fines2.ObreFitxer(e.Args[0]);
            fines2.Show();
        }

    }
}
