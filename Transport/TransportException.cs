using System;
namespace SocketIO.Unity.Transport
{
    public class TransportException : Exception
    {
        public TransportException() : base() { }
        public TransportException(string message) : base(message)
        {
            UnityEngine.Debug.LogError(message);
        }
        public TransportException(string message, Exception innerException) : base(message, innerException)
        {
            UnityEngine.Debug.LogError(message);
            UnityEngine.Debug.LogException(innerException);
        }
    }
}
