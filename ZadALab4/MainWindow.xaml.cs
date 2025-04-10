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

namespace ZadALab4
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

        private void btnOblicz_Click(object sender, RoutedEventArgs e)
        {
            double w, h, P, O;
            DaneWejscioweOkno okno1 = new DaneWejscioweOkno();

            okno1.ShowDialog();

            w = okno1.Szerokosc;
            h = okno1.Wysokosc;

            P = w * h;
            O = 2 * h + 2 * w;

            DaneWyjscioweOkno okno2 = new DaneWyjscioweOkno(P,O);
            
            okno2.ShowDialog();
        }
    }
}