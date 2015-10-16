namespace MonitoringApp_V2
{
    public class Client
    {
        public string Naam { get;}
        public int Hashcode { get; }
        private DataPanel panel;
        public Client(string naam, int hashcode, DataPanel panel)
        {
            Naam = naam;
            Hashcode = hashcode;
            this.panel = panel;
        }
    }
}