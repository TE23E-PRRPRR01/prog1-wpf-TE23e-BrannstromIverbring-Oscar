using System.Configuration;
using System.Data;
using System.Windows;

namespace AritmetikApp;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickBeräkna(object sender, RoutedEventArgs e)
    {
        // Läs in talen och operatorn från textrutorna
        string tal1Text = txbTal1.Text.Trim();
        string tal2Text = txbTal2.Text.Trim();

        // Läs in operatorn från textrutan
        string op = txbOperator.Text.Trim();

        // Konvertera texten i textrutorna till flyttal
        // Om konverteringen lyckas, spara talen i variabler
        if (double.TryParse(tal1Text, out double tal1) && double.TryParse(tal2Text, out double tal2))
        {
            // Deklarera variabel för resultatet
            double resultat;

            // Utför beräkningen beroende på operatorn
            // Visa resultatet i en label
            if (op == "+")
            {
                resultat = tal1 + tal2;
                lblResultat.Content = $"{tal1} + {tal2} = {resultat}";
            }
            else if (op == "-")
            {
                resultat = tal1 - tal2;
                lblResultat.Content = $"{tal1} - {tal2} = {resultat}";
            }
            else if (op == "*")
            {
                resultat = tal1 * tal2;
                lblResultat.Content = $"{tal1} * {tal2} = {resultat}";
            }
            else if (op == "/")
            {
                if (tal2 != 0)
                {
                    resultat = tal1 / tal2;
                    lblResultat.Content = $"{tal1} / {tal2} = {resultat}";
                }
                else
                {
                    lblResultat.Content = "Fel: Kan inte dividera med 0.";
                }
            }
            else
            {
                lblResultat.Content = "Fel: Ogiltig operator.";
            }
        }
        else
        {
            lblResultat.Content = "Fel: Ogiltigt tal.";
        }
    }
}

