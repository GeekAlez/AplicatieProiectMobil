using AplicatieProiectMobil.ViewModels;

namespace AplicatieProiectMobil.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		BindingContext = new LoginViewModel();
	}
}