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

namespace ZadC;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void btnKlik_Click(object sender, RoutedEventArgs e)
    {
        ProstopadloscianyListBox.Items.Clear();

        Prostopadloscian[] prostopadlosciany = new Prostopadloscian[]
        {
            new Prostopadloscian(2,2,2),
            new Prostopadloscian(5.2),
            new Prostopadloscian(3,5,4),
            new Prostopadloscian(8,1,2)
        };
       
        foreach(var p in prostopadlosciany)
        {
            ProstopadloscianyListBox.Items.Add(p.ToString());
        }
    }
}