using System;
using System.Diagnostics;
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
using System.Globalization;

namespace WpfApp4
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            Operacions_amb_tipus();
        }
        public void Operacions_amb_tipus()
        {

            //Tipus de dades primitius         
            //Els tipus de dades primitius tenen una mida fixa definida pel runtime de .NET

            //SBYTE  signed Byte
            //sbyte System.SByte    8 - bit signed integer    -128:127(-2^7:2^7–1)
            sbyte sbyteMin=-128;
            sbyte sbyteMax=127;
            Debug.WriteLine("Valor màxim="+sbyte.MaxValue+" i mínim "+sbyte.MinValue+" d'un sbyte");
            if(sbyteMax== sbyte.MaxValue && sbyteMin.Equals(sbyte.MinValue))
            {
                Debug.WriteLine("Comprovació sbyte perfecta!!");

            }


            //SHORT
            //short System.Int16    16 - bit signed integer   -32,768:32,767(-2^15:2^15–1)
            short shortMin = -32768;
            short shortMax = 32767;
            Debug.WriteLine("Valor màxim=" + Int16.MaxValue + " i mínim " + Int16.MinValue + " d'un short");
            if (shortMax == short.MaxValue && shortMin.Equals(short.MinValue))
            {
                Debug.WriteLine("Comprovació short perfecta!!");

            }

            //INT
            //int System.Int32    32 - bit signed integer   -2,147,483,648:2,147,483,647(-2^31:2^31–1)
            int intMin = -2147483648;
            int intMax = 2147483647;
            Debug.WriteLine("Valor màxim=" + Int32.MaxValue + " i mínim " + Int32.MinValue + " d'un int");
            if (intMax == Int32.MaxValue && intMin.Equals(Int32.MinValue))
            {
                Debug.WriteLine("Comprovació int32 (int) perfecta!!");

            }

            //LONG
            //long System.Int64    64 - bit signed integer   -9,223,372,036,854,775,808: 9,223,372,036,854,775,807(-2^63:2^63–1)
            long longMin = -9223372036854775808;
            long longMax = 9223372036854775807;
            Debug.WriteLine("Valor màxim=" + Int64.MaxValue + " i mínim " + Int64.MinValue + " d'un long");
            if (longMax == Int64.MaxValue && longMin.Equals(Int64.MinValue))
            {
                Debug.WriteLine("Comprovació int64 (long) perfecta!!");

            }

            //BYTE
            //byte System.Byte     8 - bit unsigned integer  0:255(0:2^8–1)
            byte byteMin = 0;
            byte byteMax = 255;
            Debug.WriteLine("Valor màxim=" + Byte.MaxValue + " i mínim " + Byte.MinValue + " d'un byte");
            if (byteMax == Byte.MaxValue && byteMin.Equals(Byte.MinValue))
            {
                Debug.WriteLine("Comprovació byte perfecta!!");

            }

            //UNSIGNED SHORT
            //ushort System.UInt16   16 - bit unsigned integer     0:65,535(0:2^16–1)
            ushort ushortMin = 0;
            ushort ushortMax = 65535;
            Debug.WriteLine("Valor màxim=" + UInt16.MaxValue + " i mínim " + UInt16.MinValue + " d'un unsigned short");
            if (ushortMax == UInt16.MaxValue && ushortMin.Equals(UInt16.MinValue))
            {
                Debug.WriteLine("Comprovació UInt16 (Unsigned Short) perfecta!!");

            }

            //UNSIGNED INT
            //uint System.UInt32   32 - bit unsigned integer     0:4,294,967,295(0:2^32–1)
            uint uintMin = 0;
            uint uintMax = 4294967295;
            Debug.WriteLine("Valor màxim=" + UInt32.MaxValue + " i mínim " + UInt32.MinValue + " d'un unsigned int");
            if (uintMax == UInt32.MaxValue && uintMin.Equals(UInt32.MinValue))
            {
                Debug.WriteLine("Comprovació UInt32 (Unsigned int) perfecta!!");

            }

            //UNSIGNED LONG
            //ulong System.UInt64   64 - bit unsigned integer     0:18,446,744,073,709,551,615(0:2^64–1)
            ulong ulongMin = 0;
            ulong ulongMax = 18446744073709551615;
            Debug.WriteLine("Valor màxim=" + UInt64.MaxValue + " i mínim " + UInt64.MinValue + " d'un unsigned long");
            if (ulongMax == UInt64.MaxValue && ulongMin.Equals(UInt64.MinValue))
            {
                Debug.WriteLine("Comprovació UInt64 (Unsigned long) perfecta!!");

            }


            /////////////////////////////////////////////////////////////////////////////////////
            ///
            intMax = intMax + 3;
            Debug.WriteLine($"Un example d'overflow: intMax+3 --> {intMax}");



            ////////////////////
            ///double i float
            ///
            // Si useu double o float, useu representació en coma flotant. 
            // Aquesta representació permet treballar amb magnituds molt grans o petites, 
            // però duu associada una precisió que pot fer que el valor que s'emmagatzemi 
            // no sigui exactament el valor que voliem desar.

            //FLOAT
            //float System.Single   32 - bit 
            Debug.WriteLine("Valor màxim=" + Single.MaxValue + " i mínim " + Single.MinValue + " d'un float");

            //DOUBLE
            //double System.Single   64 - bit 
            Debug.WriteLine("Valor màxim=" + Double.MaxValue + " i mínim " + Double.MinValue + " d'un double");


            /////Exemple de canvi de número
            ///
            double doublemeu;
            doublemeu = 123456789.12345678901;

            Debug.WriteLine($"Valor 123456789.12345678901 conte el doublemeu {doublemeu}");


            //Si usem decimal, treballem amb coma fixa.
            //El llenguatge ens garanteix preservar fins a 29 digits sense pèrdua d'informació. 
            //Aquest tipus de dades és el que farem servir per representar valors monetaris.
            //DECIMAL
            //decimal System.Decimal  128 bits
            Debug.WriteLine("Valor màxim=" + Decimal.MaxValue + " i mínim " + Decimal.MinValue + " d'un Decimal");

            decimal decimalmeu;

            decimalmeu = 12345678901234567890.1234567891M;
            Debug.WriteLine($"Valor que conté el decimalmeu 12345678901234567890.1234567891 ");
            Debug.WriteLine($"i conté {decimalmeu}");

            /////////////////////////
            ///LITERALS
            ///
            bool b = true;
            bool bf = false;
            int i = 10;
            long lng = 1000L;
            ulong ulng = 10000UL;
            float f = 10.4f; // f indica float
            double d = 10.4; // per defecte els nombres amb decimals són float.
            decimal dec = 10.4M; // M de Money
            char c = 'A';


            //Constants
            //Podem definir valors constants, 
            //que no es poden manipular posteriorment 
            //a la seva declaració. 
            //Cal inicialitzar la constant en la declaració.
            const int a = 100;


            //CADENES
            //Les cadenes són UNICODE(per tant cada caràcter ocupa 16bits)
            
            //Concatenació Concatenem cadenes amb l'operador +
            string nom = "Joan " + "Ignasi";
            string nom_complet = nom + " Rossell";

            //Salt de línia Podem usar els literals "\n" o "\r\n"per representar el salt de línia:
            string dosLinies = "Primera Línia\nSegona Línia";

            //És millor utilitizar la seva representació genèrica Environment.NewLine:
             dosLinies = "Primera Línia" + Environment.NewLine + "Segona Línia";

            //Autoreemplaçament Si prefixem la cadena amb un $, 
            //podem incrustar valors de variables dins de la cadena sense haver de fer concatenacions.
            string cadena = "Món";
            string autoreemplaç = $"Hola {cadena} ! ";



            //////////////////////////////////////////
            ///
            //CONVERSIONS
            //
            //Qualsevol tipus primitiu es pot convertir a cadena usant .toString()

            //Mètodes de cerca, substitució i trimming
            //MÈTODE                        FUNCIÓ
            //.Substring(posició_inicial)   retorna la subcadena que comença a posició_inicial(inclosa) fins al final
            string cadena2 = "Barcelona";
            string cadena3=cadena2.Substring(6);
            Debug.WriteLine($"La cadena3 conté ona {cadena3}");

            //.Substring(posició_inicial, num_chars)    retorna la subcadena que comença a posició_inicial(inclosa), prenent num_chars consecutius a partir de la posició inicial(la posició inicial compta)
            cadena3 = cadena2.Substring(3, 3);
            Debug.WriteLine($"La cadena3 conté cel {cadena3}");

            //.Trim()     Elimina espais en blanc a l'inici i final de la cadena
            cadena2 = "   cadena amb espais   ";
            cadena3 = cadena2.Trim();
            Debug.WriteLine($"La cadena3 no té espais a l'inici ni al final {cadena3}");

            //.Trim(char[] caracters)     Elimina els caràcters indicats al paràemtre del inici i final de la cadena
            cadena2 = "....cadena...";
            cadena3 = cadena2.Trim('.');
            Debug.WriteLine($"La cadena3 no té els punts a l'inici ni al final {cadena3}");

            //.PadLeft(num_cars)  omple la cadena per l'esquerra amb espais en blanc, fins assolir longitud num_cars
            cadena2 = "cadena";
            cadena3 = cadena2.PadLeft(10);
            Debug.WriteLine($"La cadena3 té espais a l'inici {cadena3}");

            //.PadLeft(num_cars), caracter_de_padding) 	omple la cadena per l'esquerra amb caracter_de_padding, fins assolir longitud num_cars
            cadena3 = cadena2.PadRight(10);
            Debug.WriteLine($"La cadena3 té espais al final {cadena3} <-- fins aqui");

            //.Length     longitud de la cadena
            int num = cadena.Length;
            Debug.WriteLine($"La cadena {cadena} té {num} caràcters");

            //cadena[i]   accés directe al ièssim caràcter de la cadena
            char cc = cadena2[4];


            //Conversions de tipus numèric a cadena
            //Al convertir a cadena un número,
            //podem especificar el nombre de posicions senceres i decimals, 
            //així com la utilització o no d'un separador de milers.
            double numeroDec = 2321.23;
            string numString = numeroDec.ToString("#####.000"); //2321,230

            numString = numeroDec.ToString("##,###.000"); //2.321,230
                                                          // Utilitzant un indicador de cultura
            CultureInfo us = new CultureInfo("en-US");
            numString = numeroDec.ToString("##,###.000", us); //2,321.230

            ///////////////////////
            //Conversions de tipus data a cadena
            //
            //Declaració de data
            //Les dates es representen amb el tipus DateTime, 
            //que permet emmagatzemar la data i la hora(hores, minuts i segons ) 
            //de forma conjunta.Per declarar i inicialitzar una data ho podem fer de diverses maneres:
            DateTime ara = DateTime.Now; // ARA, incloent dia i hora
            DateTime avui = DateTime.Today; // ARA, incloent dia només
            DateTime dataD = new DateTime(2018, 12, 31); // constructor explícit amb data
            DateTime dataIHora = new DateTime(2018, 12, 31, 22, 30, 59); // constructor explícit amb data i hora

            //Conversió a cadena especificant el format
            
            //Podem usar cadenes de format per especificar quina és la representació que volem assolir.
            string dataS = dataD.ToString("dd/MM/yyyy"); //  31/12/2018

            dataS = dataD.ToString("dd-MMM-yy hh:mm:ss"); // 31-dic.-17 12:00:00

            dataS = dataD.ToString("dddd, dd \\de MMMM \\de yyyy"); //lunes, 31 de diciembre de 2018

            dataS = dataD.ToString("hh:mm:ss"); //12:00:00
            CultureInfo enAU = new CultureInfo("en-AU");

            CultureInfo fr = new CultureInfo("fr-FR");
            dataS = dataD.ToString("dddd, dd \\de MMMM \\de yyyy", fr); //lundi, 31 de décembre de 2018




        }
    }

    /// <summary>
    /// ////////////////////////////////////////
    /// </summary>
    ///Col·lisió de noms entre atributs i variables locals

    //Es pot donar el cas de declarar una variable local i un atribut 
    //amb el mateix nom.Això COMPILA i és dona per vàlid:

    class Persona
    {
        private string nom = "Paco";

        public Persona()
        {
            string nom = "Maria";

            string copia = nom; // Què val "nom" aquí?

        }
    }

    //    En la línia on hi ha el comentar, fem servir la variable nom, 
    //        però hi ha certa ambigüitat doncs no sabem si ens estem referint a l'atribut o a la variable loca.l

    //La regla és senzilla, si no es diu el contrari , 
    //sempre ens referim a la* variable local* Si volem forçar la
    // referència a l'atribut cal usar el prefixe this.

    class Persona2
    {
        private string nom = "Paco";

        public Persona2()
        {
            string nom = "Maria";

            string copia = nom; // "Maria"
            string copia1 = this.nom;  // "Paco"
        }
    }



}
