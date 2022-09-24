namespace AgendaApi.Models
{
    public class PrevisaoTempo
    {
        public PrevisaoTempo(double temp_min, double temp_max, string descricao, int precipitacao)
        {
            Temp_min = temp_min;
            Temp_max = temp_max;
            Descricao = descricao;
            Precipitacao = precipitacao;
        }

        public double Temp_min { get; private set; }
        public double Temp_max { get; private set; }
        public string Descricao { get; private set; }
        public int Precipitacao { get; private set; }
    }
}
