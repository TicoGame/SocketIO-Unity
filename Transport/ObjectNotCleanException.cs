using System;
namespace SocketIO.Unity.Transport
{
    public class ObjectNotCleanException : Exception
    {
        public ObjectNotCleanException() : base("Object is not clean, may need to create a new object.") { UnityEngine.Debug.LogError("Object is not clean, may need to create a new object."); }
    }
}
