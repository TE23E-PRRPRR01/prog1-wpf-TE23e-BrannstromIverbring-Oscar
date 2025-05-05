using System.Net;
using System.Net.Mail;
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

namespace EpostApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickSkicka(object sender, RoutedEventArgs e)
    {
        string epost = tbxEpost.Text;
        string meddelande = tbxMeddelande.Text;

        SmtpClient smtp = new.SmtpClient("smtp.gmail.com", 587)
        smtp.EnableSsl = true;
        smtp.Credentials= new NetworkCredential


        if (epost != "" && meddelande != "")
        {
            lblStatus.Content ="Ok";
        }
        else
        {
            lblStatus.Content ="Fel! Något av fälten är tomma";
        }
    }

}