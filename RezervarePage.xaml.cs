using AplicatieProiectMobil.Views;
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

}