using MauiAppUsuarios.ViewModels;

namespace MauiAppUsuarios.Views;

public partial class UsersListPage : ContentPage
{
    private readonly UsersListViewModel _viewModel;

    public UsersListPage()
    {
        InitializeComponent();

        _viewModel = new UsersListViewModel();
        BindingContext = _viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (_viewModel.Usuarios.Count == 0)
        {
            _viewModel.CarregarUsuariosCommand.Execute(null);
        }
    }
    private async void AoClicarNoUsuario(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Models.User usuarioClicado)
        {
            var parametros = new Dictionary<string, object>
            {
                { UserDetailPage.ChaveUsuario, usuarioClicado }
            };

            await Shell.Current.GoToAsync(nameof(UserDetailPage), parametros);

            ((CollectionView)sender).SelectedItem = null;
        }
    }
}