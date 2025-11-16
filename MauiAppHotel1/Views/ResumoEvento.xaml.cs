using MauiAppHotel1.Models;

namespace MauiAppHotel1.Views
{
    public partial class ResumoEvento : ContentPage
    {
        public ResumoEvento(Evento evento)
        {
            InitializeComponent();
            BindingContext = evento;
        }
    }
}
