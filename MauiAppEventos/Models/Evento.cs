using System;

namespace MauiAppEventos.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public double CustoPorParticipante { get; set; }

        public int Duracao
        {
            get
            {
                return DataTermino.Subtract(DataInicio).Days + 1;
            }
        }

        public double CustoTotal
        {
            get
            {
                return NumeroParticipantes * CustoPorParticipante * Duracao;
            }
        }
    }
}