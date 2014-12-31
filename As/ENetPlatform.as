// Generated automatically with "cito". Do not edit.
package
{
	import flash.utils.ByteArray;

	public class ENetPlatform
	{

		public function castToENetAcknowledgement(a : ENetListNode) : ENetAcknowledgement
		{
			throw "Abstract method called";
		}

		public function castToENetIncomingCommand(a : ENetObject) : ENetIncomingCommand
		{
			throw "Abstract method called";
		}

		public function castToENetListNode(a : ENetObject) : ENetListNode
		{
			throw "Abstract method called";
		}

		public function castToENetOutgoingCommand(a : ENetObject) : ENetOutgoingCommand
		{
			throw "Abstract method called";
		}

		public function castToENetPeer(a : ENetListNode) : ENetPeer
		{
			throw "Abstract method called";
		}

		public function eNET_HOST_TO_NET_16(p : int) : int
		{
			throw "Abstract method called";
		}

		public function eNET_HOST_TO_NET_32(p : int) : int
		{
			throw "Abstract method called";
		}

		public function eNET_NET_TO_HOST_16(p : int) : int
		{
			throw "Abstract method called";
		}

		public function eNET_NET_TO_HOST_32(fragmentOffset : int) : int
		{
			throw "Abstract method called";
		}

		public function enet_address_set_host(address : ENetAddress, hostName : String) : int
		{
			throw "Abstract method called";
		}

		public function enet_socket_accept(socket : ENetSocket, address : ENetAddress) : int
		{
			throw "Abstract method called";
		}

		public function enet_socket_bind(socket : ENetSocket, address : ENetAddress) : int
		{
			throw "Abstract method called";
		}

		public function enet_socket_connect(socket : ENetSocket, address : ENetAddress) : int
		{
			throw "Abstract method called";
		}

		public function enet_socket_create(type : int) : ENetSocket
		{
			throw "Abstract method called";
		}

		public function enet_socket_destroy(socket : ENetSocket) : void
		{
			throw "Abstract method called";
		}

		public function enet_socket_get_address(socket : ENetSocket, address : ENetAddress) : int
		{
			throw "Abstract method called";
		}

		public function enet_socket_listen(socket : ENetSocket, backlog : int) : int
		{
			throw "Abstract method called";
		}

		public function enet_socket_receive(socket : ENetSocket, address : ENetAddress, buffers : Array, bufferCount : int) : int
		{
			throw "Abstract method called";
		}

		public function enet_socket_send(socket : ENetSocket, address : ENetAddress, buffers : Array, bufferCount : int) : int
		{
			throw "Abstract method called";
		}

		public function enet_socket_set_option(socket : ENetSocket, option : int, value : int) : int
		{
			throw "Abstract method called";
		}

		public function enet_socket_shutdown(socket : ENetSocket, how : ENetSocketShutdown) : int
		{
			throw "Abstract method called";
		}

		public function enet_socket_wait(socket : ENetSocket, condition : Array, timeout : int) : int
		{
			throw "Abstract method called";
		}

		public function enet_time_get() : int
		{
			throw "Abstract method called";
		}

		public function time() : int
		{
			throw "Abstract method called";
		}
	}
}
