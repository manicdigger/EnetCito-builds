// Generated automatically with "cito". Do not edit.
package enetcito.lib;

public abstract class ENetPlatform
{

	public abstract ENetAcknowledgement castToENetAcknowledgement(ENetListNode a);

	public abstract ENetIncomingCommand castToENetIncomingCommand(ENetObject a);

	public abstract ENetListNode castToENetListNode(ENetObject a);

	public abstract ENetOutgoingCommand castToENetOutgoingCommand(ENetObject a);

	public abstract ENetPeer castToENetPeer(ENetListNode a);

	public abstract ushort eNET_HOST_TO_NET_16(ushort p);

	public abstract int eNET_HOST_TO_NET_32(int p);

	public abstract ushort eNET_NET_TO_HOST_16(ushort p);

	public abstract int eNET_NET_TO_HOST_32(int fragmentOffset);

	public abstract ushort intToUshort(int p);

	public abstract int enet_address_set_host(ENetAddress address, String hostName);

	public abstract int enet_socket_accept(ENetSocket socket, ENetAddress address);

	public abstract int enet_socket_bind(ENetSocket socket, ENetAddress address);

	public abstract int enet_socket_connect(ENetSocket socket, ENetAddress address);

	public abstract ENetSocket enet_socket_create(int type);

	public abstract void enet_socket_destroy(ENetSocket socket);

	public abstract int enet_socket_get_address(ENetSocket socket, ENetAddress address);

	public abstract int enet_socket_listen(ENetSocket socket, int backlog);

	public abstract int enet_socket_receive(ENetSocket socket, ENetAddress address, ENetBuffer[] buffers, int bufferCount);

	public abstract int enet_socket_send(ENetSocket socket, ENetAddress address, ENetBuffer[] buffers, int bufferCount);

	public abstract int enet_socket_set_option(ENetSocket socket, int option, int value);

	public abstract int enet_socket_shutdown(ENetSocket socket, ENetSocketShutdown how);

	public abstract int enet_socket_wait(ENetSocket socket, int[] condition, int timeout);

	public abstract int enet_time_get();

	public abstract int time();
}
