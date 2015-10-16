namespace MonitoringApp_V2
{
    public class Client
    {
        public string Naam { get;}
        public int Id {get; }
        public DataPanel Panel { get; }
        public Client(string naam, int hashcode, DataPanel panel)
        {
            Naam = naam;
            Id = hashcode;
            Panel = panel;
        }
    }
}