using System.ComponentModel;
using System.Reflection.Metadata;
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

namespace KlappApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        listan.IsEnabled = false;
        inmatning.IsEnabled = false;
    }
    private void KlickMaxKnappar(object sender, RoutedEventArgs e)
    {
        if (int.TryParse(txbAntalJulKlappar.Text, out int antal) && antal > 0)
        {
            maxJulklappar = antal;

            lstJulklappar.ItemsSource = julklappar;

            listan.IsEnabled = true;
            inmatning.IsEnabled = true;
            limit.IsEnabled = false;
        }
        else
        {
            txbStatus.Text = "Ange ett positivt heltal.";
            txbAntalJulklappar.Text = "";
        }

        private void KlickLäggTill(object sender, RoutedEventArgs e)
        {
            if(julklappar.Count < maxJulklappar)
            {
                if(txbJulklapp.Text != "" && txbMottagare.Text != "")
                {
                    string julklapp = $"{txbJulklapp.Text} till {txbMottagare.Text}";
                    julklappar.Add(julklapp);
                    lstJulklappar.Items.Refresh();
                }
                 else
                {
                    txbStatus.Text = "Ange både julklapp och mottagare.";
                }
            }
            else
            {
                txbStatus.Text = "Max antal julklappar är uppnått";
            }
           
        }
    }
}