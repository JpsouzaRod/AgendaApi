namespace AgendaApi.Data
{
    public interface IDatabaseConfig
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }
    }
}
