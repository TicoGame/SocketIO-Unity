﻿using SocketIO.Unity.Transport;
using System.Collections.Generic;

namespace SocketIO.Unity.Messages
{
    public class PingMessage : IMessage
    {
        public MessageType Type => MessageType.Ping;

        public List<byte[]> OutgoingBytes { get; set; }

        public List<byte[]> IncomingBytes { get; set; }

        public int BinaryCount { get; }

        public EngineIO EIO { get; set; }

        public TransportProtocol Protocol { get; set; }

        public void Read(string msg)
        {
        }

        public string Write() => "2";
    }
}

