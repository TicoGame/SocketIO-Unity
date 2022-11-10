using System;
namespace SocketIO.Unity.Exceptions
{
    public class ConnectionException : Exception
    {
        public ConnectionException(string message, Exception innerException) : base(message, innerException) {
            UnityEngine.Debug.LogError(message);
            UnityEngine.Debug.LogException(innerException);
        }
    }
}
