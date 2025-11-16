using MauiAppHotel1.Models;

namespace MauiAppHotel1.Views
{
    public partial class CadastroEvento : ContentPage
    {
        Evento evento = new Evento();

        public CadastroEvento()
        {
            InitializeComponent();
            BindingContext = evento;
        }

        private async void CadastrarEvento_Clicked(object sender, EventArgs e)
        {
            // Pegando o evento que está no BindingContext
            var evento = (Evento)BindingContext;
            // Envia o objeto evento para a página de resumo
            await Navigation.PushAsync(new ResumoEvento(evento));
        }

        private void DataInicio_DateSelected(object sender, DateChangedEventArgs e)
        {
            DatePicker elemento = sender as DatePicker;

            DateTime data_selecionada_datainicio = elemento.Date;
            dtpck_datainicio.MinimumDate = data_selecionada_datainicio.AddDays(0);
            dtpck_datatermino.MinimumDate = data_selecionada_datainicio.AddMonths(6);
        }
    }
}
