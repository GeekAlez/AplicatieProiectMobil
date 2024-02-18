using AplicatieProiectMobil.Views;
using System.Text.RegularExpressions;
namespace AplicatieProiectMobil;


public partial class RezervarePage : ContentPage
{
	public RezervarePage()
	{
		InitializeComponent();
	}

    public async void OnTrimiteClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Ok", "Mulțumim pentru rezervare! Veți primi un e-mail în legătură cu aceasta.", "OK");
    }

    public async void OnLogoutClicked(object sender, EventArgs e)
    {
        var loginPage = new LoginPage();
        await Navigation.PushAsync(loginPage);
    }


    private void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        // Verificare validitate
        if (!IsValid(e.NewTextValue))
        {
            // Afiseaza un mesaj de eroare sau iau alte masuri
            DisplayAlert("Eroare", "Numele trebuie să conțină doar litere", "OK");
        }
    }

    private bool IsValid(string text)
    {
        // Logica de validare, de exemplu, doar litere
        return Regex.IsMatch(text, "^[a-zA-Z]+$");
    }

}