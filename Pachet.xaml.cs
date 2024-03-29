using AplicatieProiectMobil.ViewModels;
using AplicatieProiectMobil;

namespace AplicatieProiectMobil;

public partial class Pachet : ContentPage
{

    private readonly PachetViewModel _viewModel;


    public Pachet(PachetViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _viewModel.InitializeAsync();
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        var paginaPachete = new PaginaPachete();
        Navigation.PushAsync(paginaPachete);
    }
}

