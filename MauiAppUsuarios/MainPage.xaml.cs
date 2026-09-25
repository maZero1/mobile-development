namespace MauiAppUsuarios;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void AoClicarNoBotaoCarregar(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("UsersListPage");
    }
}