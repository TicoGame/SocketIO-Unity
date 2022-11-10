using System.Collections.Generic;

namespace SocketIO.Unity.Transport
{
    public class Payload
    {
        public string Text { get; set; }
        public List<byte[]> Bytes { get; set; }
    }
}
