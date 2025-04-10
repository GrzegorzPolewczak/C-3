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

namespace ZadALab4
{
    /// <summary>
    /// Logika interakcji dla klasy DaneWyjscioweOkno.xaml
    /// </summary>
    public partial class DaneWyjscioweOkno : Window
    {
        public DaneWyjscioweOkno()
        {
            InitializeComponent();
        }

        public DaneWyjscioweOkno(double P, double O) : this()
        {
            this.tbkPole.Text = $"{P:F2} [m^2]";
            this.tbkObwod.Text = $"{O:F2} [m]";
        }
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
