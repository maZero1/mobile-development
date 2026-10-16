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
        // Verifica se realmente pegou um usuário válido no clique
        if (e.CurrentSelection.FirstOrDefault() is Models.User usuarioClicado)
        {
            // Cria um "pacote" com o usuário clicado para enviar para a tela de detalhes
            var parametros = new Dictionary<string, object>
            {
                { UserDetailPage.ChaveUsuario, usuarioClicado }
            };

            // Manda o aplicativo navegar para a terceira tela, levando o pacote junto
            await Shell.Current.GoToAsync(nameof(UserDetailPage), parametros);

            // Tira a marcação visual de "selecionado" da lista
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}