using AplicatieProiectMobil.Views;

namespace AplicatieProiectMobil;

public partial class AppShell : Shell
{
    private LoginPage loginPage;

    public AppShell()
    {
        InitializeComponent();
    }

    public AppShell(LoginPage loginPage)
    {
        this.loginPage = loginPage;
    }
}