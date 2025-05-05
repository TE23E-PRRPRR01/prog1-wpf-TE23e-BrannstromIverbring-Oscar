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

namespace GissaApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }


    private void KlickGissa(object sender, RoutedEventArgs e)
    {
        string input = txbGissning.Text;

        int.TryParse( input, out int gissning);

        int slumptal = Random.Shared.Next(1, 1001);

        if (gissning == slumptal)
        {

        }
        else
        {

        }
    }

    private void KlickVisaGissningar(object sender, RoutedEventArgs e)
    {

    }

    private void KlickaVisaFacit(object sender, RoutedEventArgs e)
    {

    }
}