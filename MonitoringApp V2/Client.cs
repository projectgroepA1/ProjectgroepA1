using NetLib;

namespace MonitoringApp_V2
{
    public class Client
    {
        public Identifier Identifier { get; }
        public DataPanel Panel { get; }
        public Client(Identifier identifier, DataPanel panel)
        {
            this.Identifier = identifier;
            Panel = panel;
        }
    }
}