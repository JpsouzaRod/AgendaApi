namespace AgendaApi.Data
{
    public class DatabaseConfig : IDatabaseConfig
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }
    }
}
