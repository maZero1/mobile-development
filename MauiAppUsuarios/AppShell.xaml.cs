using MauiAppUsuarios.Views;

namespace MauiAppUsuarios
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("UsersListPage", typeof(UsersListPage));
            Routing.RegisterRoute("UserDetailPage", typeof(UserDetailPage));
        }
    }
}
