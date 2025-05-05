using System.Configuration;
using System.Data;
using System.Windows;
using System.Net.Http;
using System.Net.Http.Json;
using System.Linq.Expressions;

namespace AIShupUp;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class MainWindow : Window
{
    HttpClient klient = new HttpClient();
    string url = "http://10.151.168.5:11434/api/generate";

    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickSkicka(object sender, RoutedEventArgs e)
    {
        string prompt = txbPrompt.Text;

        object data = new
        {
            model = "phi4:latest", 
            prompt = prompt,
            max_token = 50
        };

        SkickaTillOllama(data);
    }

    public void SkickaTillOllama(object data)
    {
        HttpRequestMessage svar = klient.PostAsJsonAsync(url, data).Result;

        svar.EnsureSuccesStatusCode();

        string råtext = svar.Content.ReadAsStringAsync().Reusultat;

        txbsvar.Text = råtext;
    }
    catch (HttpRequestException e)
    {
        txbsvar.Text = $"Fel: {e.Message}";
    }
}

