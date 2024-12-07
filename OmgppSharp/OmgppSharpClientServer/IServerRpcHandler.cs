using System.Net;

namespace OmgppSharpClientServer
{
    public interface IServerRpcHandler
    {
        public delegate void ServerRpcHandlerDelegate(Server server, Guid clientGuid, IPAddress ip, ushort port, bool isReliable, long methodId, ulong requestId, long argType, byte[]? argData);

        public void HandleRpc(Server server, Guid clientGuid, IPAddress ip, ushort port, bool isReliable, long methodId, ulong requestId, long argType, byte[]? argData);

    }
}
