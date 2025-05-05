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

namespace Ceasar;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickKryptera(object sender, RoutedEventArgs e)
    {
        string inputText = txbInput.Text;
        string keyText = txbKey.Text;

        int.TryParse(keyText, out int key);

        txbOutput.Clear();

        foreach (var bokstav in inputText)
        {
            int ascii = (int)bokstav;

            int asciiKrypterad = ascii + key;
            char bokstavKrypterad = (char)asciiKrypterad;

            txbOutput.Text += $"{bokstavKrypterad}";
        }
    }
}