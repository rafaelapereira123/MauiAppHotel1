using MauiAppHotel1.Views;
namespace MauiAppHotel1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(CadastroEvento), typeof(CadastroEvento));
            Routing.RegisterRoute(nameof(ResumoEvento), typeof(ResumoEvento));
        }
    }
}
