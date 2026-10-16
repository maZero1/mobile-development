using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiAppUsuarios.Models;
using MauiAppUsuarios.Services;

namespace MauiAppUsuarios.ViewModels;

//observableObject é a classe base que permite que a tela saiba quando uma variável mudou de valor (Observer)
//partial serve para o toolkit ajudar no codigo
public partial class UsersListViewModel : ObservableObject
{
    private readonly ApiService _apiService;

    public ObservableCollection<User> Usuarios { get; } = new();

    [ObservableProperty]
    private bool isBusy;

    public UsersListViewModel()
    {
        _apiService = new ApiService();
    }

    [RelayCommand]
    public async Task CarregarUsuariosAsync()
    {
        if (IsBusy) return;

        try
        {
            IsBusy = true;

            var listaDaApi = await _apiService.GetUsersAsync();

            Usuarios.Clear();
            foreach (var user in listaDaApi)
            {
                Usuarios.Add(user);
            }
        }
        catch (Exception)
        {
            await Shell.Current.DisplayAlertAsync("Erro", "Não foi possível carregar os usuários.", "OK");
        }
        finally
        {
            IsBusy = false;
        }
    }
}