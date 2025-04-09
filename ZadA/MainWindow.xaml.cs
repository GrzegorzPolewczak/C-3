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

namespace ZadA;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void btnPrzycisk_Click(object sender, RoutedEventArgs e)
    {
        Obywatel.Obywatele.Clear();
        ObywateleListBox.Items.Clear();

        new Obywatel("Kowalski", 12345678910 );
        new Obywatel("Polewczak", 23456789012);
        new Obywatel("Szczepke", 34567890123);

        foreach (var obywatel in Obywatel.Obywatele)
        {
            ObywateleListBox.Items.Add(obywatel.ToString());
        }
    }
}