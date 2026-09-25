namespace MauiAppUsuarios.Views;

[QueryProperty(nameof(Usuario), "UsuarioSelecionado")]
public partial class UserDetailPage : ContentPage
{
    private Models.User _usuario;

    public Models.User Usuario
    {
        get => _usuario;
        set
        {
            _usuario = value;
            BindingContext = _usuario; 
        }
    }

    public UserDetailPage()
    {
        InitializeComponent();
    }
}