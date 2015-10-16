namespace MonitoringApp_V2
{
    public class Client
    {
        public string Naam { get;}
        public int Hashcode { get; }
        public DataPanel Panel { get; }
        public Client(string naam, int hashcode, DataPanel panel)
        {
            Naam = naam;
            Hashcode = hashcode;
            Panel = panel;
        }
    }
}