using System.Net.Http;
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

namespace Kontaktboken;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void KlickVisa(object sender, RoutedEventArgs e)
    {
        string titelText = txbTitel.Text;
        string fornamnText = txbFornamn.Text;
        string efternamnText = txbEfternamn.Text;
        string ålderText = txbÅlder.Text;
    
        int.TryParse(ålderText, out int ålder);

        if (titelText == "Herr" || titelText == "Fru")
        {
            if (0 < ålder && ålder < 120)
            {
                txbResultat.Text = $"Titel: {titelText}\nFörnamn: {fornamnText}\nEfternamn: {efternamnText}\nÅlder: {ålderText}";

            }
            else
            {
                txbResultat.Text = $"Ålder är fel!";
            }
        }
        else
        {
            txbResultat.Text = $"Felaktig titel! Vänligen ange Herr eller Fru.";
        }
    }
    private void KlickRensa(object sender, RoutedEventArgs e)
    {
        txbTitel.Clear();
        txbFornamn.Clear();
        txbEfternamn.Clear();
        txbÅlder.Clear();
        txbResultat.Clear();
    }
    private void KlickLista(object sender, RoutedEventArgs e)
    {
        
    }
}