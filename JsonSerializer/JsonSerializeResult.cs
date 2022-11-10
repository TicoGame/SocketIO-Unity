using System.Collections.Generic;

namespace SocketIO.Unity.JsonSerializer
{
    public class JsonSerializeResult
    {
        public string Json { get; set; }
        public IList<byte[]> Bytes { get; set; }
    }
}
