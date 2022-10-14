using System;
using System.Text.Json.Serialization;

namespace AgendaApi.Models
{
    public class PrevisaoTempo
    {
        public PrevisaoTempo(dynamic obj)
        {
            Date = obj.day;
            TempMin = obj.temp_min;
            TempMax = obj.temp_max;
            Descricao = obj.description;
            Precipitacao = obj.pop;
        }

        public DateTime Date { get; private set; }
        public double TempMin { get; private set; }
        public double TempMax { get; private set; }
        public string Descricao { get; private set; }
        public float Precipitacao { get; private set; }
    }
}
