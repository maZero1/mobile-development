using System.Net.Http.Json;
using MauiAppUsuarios.Models;

namespace MauiAppUsuarios.Services;

public class ApiService
{
    private readonly HttpClient _httpClient;

    public ApiService()
    {
        _httpClient = new HttpClient();
        _httpClient.Timeout = TimeSpan.FromSeconds(5);
    }

    public async Task<List<User>> GetUsersAsync()
    {
        var url = "https://jsonplaceholder.typicode.com/users";

        var users = await _httpClient.GetFromJsonAsync<List<User>>(url);

        return users ?? new List<User>();
    }
}