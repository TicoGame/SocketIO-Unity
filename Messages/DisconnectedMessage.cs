﻿using SocketIO.Unity.Transport;
using System.Collections.Generic;
namespace SocketIO.Unity.Messages
{
    public class DisconnectedMessage : IMessage
    {
        public MessageType Type => MessageType.Disconnected;

        public string Namespace { get; set; }

        public List<byte[]> OutgoingBytes { get; set; }

        public List<byte[]> IncomingBytes { get; set; }

        public int BinaryCount { get; }

        public EngineIO EIO { get; set; }

        public TransportProtocol Protocol { get; set; }

        public void Read(string msg)
        {
            Namespace = msg.TrimEnd(',');
        }

        public string Write()
        {
            if (string.IsNullOrEmpty(Namespace))
            {
                return "41";
            }
            return "41" + Namespace + ",";
        }
    }
}
