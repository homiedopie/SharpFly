﻿namespace SharpFly_Packet_Library.Packets.Interserver.Incoming
{
    public class RegisterNewChannelRequest
    {
        public string AuthorizationPassword { get; private set; }
        public uint ClusterId { get; private set; }
        public uint TempChannelId { get; private set; }
        public string Name { get; private set; }
        public uint MaxPlayerCount { get; private set; }

        public RegisterNewChannelRequest(IncomingInterserverPacket packet)
        {
            AuthorizationPassword = packet.ReadString();
            ClusterId = packet.ReadUInt();
            TempChannelId = packet.ReadUInt();
            Name = packet.ReadString();
            MaxPlayerCount = packet.ReadUInt();
        }
    }
}
