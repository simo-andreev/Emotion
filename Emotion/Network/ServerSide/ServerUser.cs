﻿using Emotion.Network.Base;
using Emotion.Utility;
using System.Net;

#nullable enable

namespace Emotion.Network.ServerSide;

public class ServerUser
{
    public static ObjectPool<ServerUser> Shared = new ObjectPool<ServerUser>((r) => r.Reset(), 50);

    public IPEndPoint? MyIP;
    public int MessageIndex = 1;

    public void Reset()
    {
        MyIP = null;
        MessageIndex = 1;
    }

    public void SendMessage(Server server, ReadOnlySpan<byte> data)
    {
        AssertNotNull(MyIP);
        server.SendMessage(data, MyIP, MessageIndex);
        MessageIndex++;
    }

    public void SendMessage(Server server, NetworkMessageType shorthand)
    {
        Span<byte> data = stackalloc byte[1];
        data[0] = (byte)shorthand;

        AssertNotNull(MyIP);
        server.SendMessage(data, MyIP, MessageIndex);
        MessageIndex++;
    }
}
