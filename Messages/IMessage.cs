﻿using System;
using System.Collections.Generic;
using SocketIO.Unity.Transport;

namespace SocketIO.Unity.Messages
{
    public interface IMessage
    {
        MessageType Type { get; }

        List<byte[]> OutgoingBytes { get; set; }

        List<byte[]> IncomingBytes { get; set; }

        int BinaryCount { get; }

        EngineIO EIO { get; set; }

        TransportProtocol Protocol { get; set; }

        void Read(string msg);

        //void Eio3WsRead(string msg);

        //void Eio3HttpRead(string msg);

        string Write();

        //string Eio3WsWrite();
    }
}
