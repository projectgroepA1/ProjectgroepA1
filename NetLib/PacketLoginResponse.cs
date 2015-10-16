using System;

namespace NetLib
{
    [Serializable]
    public class PacketLoginResponse : Packet
    {
        public bool loginOk { get; set; }
        public int number { get; set; }

        public override void handleClientSide(ClientInterface clientInterface)
        {
            clientInterface.loginResponse(loginOk);
        }
 
    }
}
