namespace Catalog.Settings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string BookCollectionName { get; set; }
        public string CategoryCollectionName { get; set; }
        public string LocationCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
