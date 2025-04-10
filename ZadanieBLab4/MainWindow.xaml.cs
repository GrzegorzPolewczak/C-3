using Geometria;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZadanieBLab4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnKula_Click(object sender, RoutedEventArgs e)
        {
            Kula kula1 = new Kula("KulaDAJEfula", 5, 30.0, 20);
            lbWynik.Content = kula1.ToString();
        }

        private void btnStozek_Click(object sender, RoutedEventArgs e)
        {
            Stozek stozek1 = new Stozek("midaTOhubert",5,10,20,50);
            lbWynik.Content = stozek1.ToString();
        }

        private void btnKlik_Click(object sender, RoutedEventArgs e)
        {
            List<IWyswietl> lista = new List<IWyswietl>
            {
                new Kula("KulaDAJEFULA",2,50,5),
                new Kula("KulaDAJEFULA",2,50,5),
                new Stozek("Potezny Stozek", 5,10,25,2),
                new Student("Makub", "Jida"),
                new Student("Sziotr","Pczepanik")
            };
            lista.Sort();
            WyswietlListBox.Items.Clear();


            foreach (var l in lista)
                WyswietlListBox.Dodaj(l);



        }
    }
}