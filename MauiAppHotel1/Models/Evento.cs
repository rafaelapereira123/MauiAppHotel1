namespace MauiAppHotel1.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public decimal CustoPorParticipante { get; set; }

        // Duração em dias do evento
        public int DuracaoDias
        {
            get
            {
                TimeSpan diferenca = DataTermino - DataInicio;
                return diferenca.Days;
            }
        }

        // Cálculo de custo total
        public decimal CustoTotal
        {
            get
            {
                return NumeroParticipantes * CustoPorParticipante;
            }
        }
    }
}

