// Generated automatically with "cito". Do not edit.
import std.utf;

class Byte
{
	ubyte value;
}

class ENet
{

	private ENetProtocolHeader Deserialize(const(ubyte)[] a)
	{
		ENetProtocolHeader h = new ENetProtocolHeader;
		h.peerID = this.ReadShort(a, 0);
		h.sentTime = this.ReadShort(a, 2);
		return h;
	}

	private void DeserializeProtocolCommandCommand(const(ubyte)[] readBuf, int currentDataI, ubyte commandNumber, ENetProtocol command)
	{
		int pos = currentDataI + 4;
		switch (commandNumber) {
		case 1:
			command.acknowledge = new ENetProtocolAcknowledge;
			command.acknowledge.receivedReliableSequenceNumber = this.ReadShort(readBuf, pos);
			pos += 2;
			command.acknowledge.receivedSentTime = this.ReadShort(readBuf, pos);
			pos += 2;
			break;
		case 2:
			command.connect = new ENetProtocolConnect;
			command.connect.outgoingPeerID = this.ReadShort(readBuf, pos);
			pos += 2;
			command.connect.incomingSessionID = this.ReadByte(readBuf, pos);
			pos += 1;
			command.connect.outgoingSessionID = this.ReadByte(readBuf, pos);
			pos += 1;
			command.connect.mtu = this.ReadInt(readBuf, pos);
			pos += 4;
			command.connect.windowSize = this.ReadInt(readBuf, pos);
			pos += 4;
			command.connect.channelCount = this.ReadInt(readBuf, pos);
			pos += 4;
			command.connect.incomingBandwidth = this.ReadInt(readBuf, pos);
			pos += 4;
			command.connect.outgoingBandwidth = this.ReadInt(readBuf, pos);
			pos += 4;
			command.connect.packetThrottleInterval = this.ReadInt(readBuf, pos);
			pos += 4;
			command.connect.packetThrottleAcceleration = this.ReadInt(readBuf, pos);
			pos += 4;
			command.connect.packetThrottleDeceleration = this.ReadInt(readBuf, pos);
			pos += 4;
			command.connect.connectID = this.ReadInt(readBuf, pos);
			pos += 4;
			command.connect.data = this.ReadInt(readBuf, pos);
			pos += 4;
			break;
		case 3:
			command.verifyConnect = new ENetProtocolVerifyConnect;
			command.verifyConnect.outgoingPeerID = this.ReadShort(readBuf, pos);
			pos += 2;
			command.verifyConnect.incomingSessionID = this.ReadByte(readBuf, pos);
			pos += 1;
			command.verifyConnect.outgoingSessionID = this.ReadByte(readBuf, pos);
			pos += 1;
			command.verifyConnect.mtu = this.ReadInt(readBuf, pos);
			pos += 4;
			command.verifyConnect.windowSize = this.ReadInt(readBuf, pos);
			pos += 4;
			command.verifyConnect.channelCount = this.ReadInt(readBuf, pos);
			pos += 4;
			command.verifyConnect.incomingBandwidth = this.ReadInt(readBuf, pos);
			pos += 4;
			command.verifyConnect.outgoingBandwidth = this.ReadInt(readBuf, pos);
			pos += 4;
			command.verifyConnect.packetThrottleInterval = this.ReadInt(readBuf, pos);
			pos += 4;
			command.verifyConnect.packetThrottleAcceleration = this.ReadInt(readBuf, pos);
			pos += 4;
			command.verifyConnect.packetThrottleDeceleration = this.ReadInt(readBuf, pos);
			pos += 4;
			command.verifyConnect.connectID = this.ReadInt(readBuf, pos);
			pos += 4;
			break;
		case 4:
			command.disconnect = new ENetProtocolDisconnect;
			command.disconnect.data = this.ReadInt(readBuf, pos);
			pos += 4;
			break;
		case 5:
			command.ping = new ENetProtocolPing;
			break;
		case 6:
			command.sendReliable = new ENetProtocolSendReliable;
			command.sendReliable.dataLength = this.ReadShort(readBuf, pos);
			pos += 2;
			break;
		case 7:
			command.sendUnreliable = new ENetProtocolSendUnreliable;
			command.sendUnreliable.unreliableSequenceNumber = this.ReadShort(readBuf, pos);
			pos += 2;
			command.sendUnreliable.dataLength = this.ReadShort(readBuf, pos);
			pos += 2;
			break;
		case 9:
			command.sendUnsequenced = new ENetProtocolSendUnsequenced;
			command.sendUnsequenced.unsequencedGroup = this.ReadShort(readBuf, pos);
			pos += 2;
			command.sendUnsequenced.dataLength = this.ReadShort(readBuf, pos);
			pos += 2;
			break;
		case 8:
			command.sendFragment = new ENetProtocolSendFragment;
			command.sendFragment.startSequenceNumber = this.ReadShort(readBuf, pos);
			pos += 2;
			command.sendFragment.dataLength = this.ReadShort(readBuf, pos);
			pos += 2;
			command.sendFragment.fragmentCount = this.ReadInt(readBuf, pos);
			pos += 4;
			command.sendFragment.fragmentNumber = this.ReadInt(readBuf, pos);
			pos += 4;
			command.sendFragment.totalLength = this.ReadInt(readBuf, pos);
			pos += 4;
			command.sendFragment.fragmentOffset = this.ReadInt(readBuf, pos);
			pos += 4;
			break;
		case 10:
			command.bandwidthLimit = new ENetProtocolBandwidthLimit;
			command.bandwidthLimit.incomingBandwidth = this.ReadInt(readBuf, pos);
			pos += 4;
			command.bandwidthLimit.outgoingBandwidth = this.ReadInt(readBuf, pos);
			pos += 4;
			break;
		case 11:
			command.throttleConfigure = new ENetProtocolThrottleConfigure;
			command.throttleConfigure.packetThrottleInterval = this.ReadInt(readBuf, pos);
			pos += 4;
			command.throttleConfigure.packetThrottleAcceleration = this.ReadInt(readBuf, pos);
			pos += 4;
			command.throttleConfigure.packetThrottleDeceleration = this.ReadInt(readBuf, pos);
			pos += 4;
			break;
		case 12:
			command.sendFragment = new ENetProtocolSendFragment;
			command.sendFragment.startSequenceNumber = this.ReadShort(readBuf, pos);
			pos += 2;
			command.sendFragment.dataLength = this.ReadShort(readBuf, pos);
			pos += 2;
			command.sendFragment.fragmentCount = this.ReadInt(readBuf, pos);
			pos += 4;
			command.sendFragment.fragmentNumber = this.ReadInt(readBuf, pos);
			pos += 4;
			command.sendFragment.totalLength = this.ReadInt(readBuf, pos);
			pos += 4;
			command.sendFragment.fragmentOffset = this.ReadInt(readBuf, pos);
			pos += 4;
			break;
		default:
			break;
		}
	}

	private ENetProtocol DeserializeProtocolCommandHeader(const(ubyte)[] currentData, int currentDataI)
	{
		int pos = currentDataI;
		ENetProtocol a = new ENetProtocol;
		a.header = new ENetProtocolCommandHeader;
		a.header.command = this.ReadByte(currentData, pos);
		pos += 1;
		a.header.channelID = this.ReadByte(currentData, pos);
		pos += 1;
		a.header.reliableSequenceNumber = this.ReadShort(currentData, pos);
		pos += 2;
		return a;
	}
	public static immutable(int) ENET_BUFFER_MAXIMUM = 65;
	public static immutable(int) ENET_HOST_ANY = 0;
	public static immutable(int) ENET_HOST_BANDWIDTH_THROTTLE_INTERVAL = 1000;
	public static immutable(int) ENET_HOST_BROADCAST = -1;
	public static immutable(int) ENET_HOST_DEFAULT_MTU = 1400;
	public static immutable(int) ENET_HOST_RECEIVE_BUFFER_SIZE = 262144;
	public static immutable(int) ENET_HOST_SEND_BUFFER_SIZE = 262144;

	private ushort ENET_HOST_TO_NET_16(ushort a)
	{
		return this.p.ENET_HOST_TO_NET_16(a);
	}

	private final int ENET_HOST_TO_NET_32(int a)
	{
		return this.p.ENET_HOST_TO_NET_32(a);
	}

	private int ENET_MAX(int x, int y)
	{
		return x > y ? x : y;
	}

	private int ENET_MIN(int x, int y)
	{
		return x < y ? x : y;
	}

	private ushort ENET_NET_TO_HOST_16(ushort a)
	{
		return this.p.ENET_NET_TO_HOST_16(a);
	}

	private int ENET_NET_TO_HOST_32(int a)
	{
		return this.p.ENET_NET_TO_HOST_32(a);
	}
	public static immutable(int) ENET_PEER_DEFAULT_PACKET_THROTTLE = 32;
	public static immutable(int) ENET_PEER_DEFAULT_ROUND_TRIP_TIME = 500;
	public static immutable(int) ENET_PEER_FREE_RELIABLE_WINDOWS = 8;
	public static immutable(int) ENET_PEER_FREE_UNSEQUENCED_WINDOWS = 32;
	public static immutable(int) ENET_PEER_PACKET_LOSS_INTERVAL = 10000;
	public static immutable(int) ENET_PEER_PACKET_LOSS_SCALE = 65536;
	public static immutable(int) ENET_PEER_PACKET_THROTTLE_ACCELERATION = 2;
	public static immutable(int) ENET_PEER_PACKET_THROTTLE_COUNTER = 7;
	public static immutable(int) ENET_PEER_PACKET_THROTTLE_DECELERATION = 2;
	public static immutable(int) ENET_PEER_PACKET_THROTTLE_INTERVAL = 5000;
	public static immutable(int) ENET_PEER_PACKET_THROTTLE_SCALE = 32;
	public static immutable(int) ENET_PEER_PING_INTERVAL = 500;
	public static immutable(int) ENET_PEER_RELIABLE_WINDOWS = 16;
	public static immutable(int) ENET_PEER_RELIABLE_WINDOW_SIZE = 4096;
	public static immutable(int) ENET_PEER_TIMEOUT_LIMIT = 32;
	public static immutable(int) ENET_PEER_TIMEOUT_MAXIMUM = 30000;
	public static immutable(int) ENET_PEER_TIMEOUT_MINIMUM = 5000;
	public static immutable(int) ENET_PEER_UNSEQUENCED_WINDOWS = 64;
	public static immutable(int) ENET_PEER_UNSEQUENCED_WINDOW_SIZE = 1024;
	public static immutable(int) ENET_PEER_WINDOW_SIZE_SCALE = 65536;
	public static immutable(int) ENET_PORT_ANY = 0;
	public static immutable(int) ENET_PROTOCOL_COMMAND_ACKNOWLEDGE = 1;
	public static immutable(int) ENET_PROTOCOL_COMMAND_BANDWIDTH_LIMIT = 10;
	public static immutable(int) ENET_PROTOCOL_COMMAND_CONNECT = 2;
	public static immutable(int) ENET_PROTOCOL_COMMAND_COUNT = 13;
	public static immutable(int) ENET_PROTOCOL_COMMAND_DISCONNECT = 4;
	public static immutable(int) ENET_PROTOCOL_COMMAND_FLAG_ACKNOWLEDGE = 128;
	public static immutable(int) ENET_PROTOCOL_COMMAND_FLAG_UNSEQUENCED = 64;
	public static immutable(int) ENET_PROTOCOL_COMMAND_MASK = 15;
	public static immutable(int) ENET_PROTOCOL_COMMAND_NONE = 0;
	public static immutable(int) ENET_PROTOCOL_COMMAND_PING = 5;
	public static immutable(int) ENET_PROTOCOL_COMMAND_SEND_FRAGMENT = 8;
	public static immutable(int) ENET_PROTOCOL_COMMAND_SEND_RELIABLE = 6;
	public static immutable(int) ENET_PROTOCOL_COMMAND_SEND_UNRELIABLE = 7;
	public static immutable(int) ENET_PROTOCOL_COMMAND_SEND_UNRELIABLE_FRAGMENT = 12;
	public static immutable(int) ENET_PROTOCOL_COMMAND_SEND_UNSEQUENCED = 9;
	public static immutable(int) ENET_PROTOCOL_COMMAND_THROTTLE_CONFIGURE = 11;
	public static immutable(int) ENET_PROTOCOL_COMMAND_VERIFY_CONNECT = 3;
	public static immutable(int) ENET_PROTOCOL_HEADER_FLAG_COMPRESSED = 16384;
	public static immutable(int) ENET_PROTOCOL_HEADER_FLAG_MASK = 49152;
	public static immutable(int) ENET_PROTOCOL_HEADER_FLAG_SENT_TIME = 32768;
	public static immutable(int) ENET_PROTOCOL_HEADER_SESSION_MASK = 12288;
	public static immutable(int) ENET_PROTOCOL_HEADER_SESSION_SHIFT = 12;
	public static immutable(int) ENET_PROTOCOL_MAXIMUM_CHANNEL_COUNT = 255;
	public static immutable(int) ENET_PROTOCOL_MAXIMUM_FRAGMENT_COUNT = 1048576;
	public static immutable(int) ENET_PROTOCOL_MAXIMUM_MTU = 4096;
	public static immutable(int) ENET_PROTOCOL_MAXIMUM_PACKET_COMMANDS = 32;
	public static immutable(int) ENET_PROTOCOL_MAXIMUM_PACKET_SIZE = 1073741824;
	public static immutable(int) ENET_PROTOCOL_MAXIMUM_PEER_ID = 4095;
	public static immutable(int) ENET_PROTOCOL_MAXIMUM_WINDOW_SIZE = 32768;
	public static immutable(int) ENET_PROTOCOL_MINIMUM_CHANNEL_COUNT = 1;
	public static immutable(int) ENET_PROTOCOL_MINIMUM_MTU = 576;
	public static immutable(int) ENET_PROTOCOL_MINIMUM_WINDOW_SIZE = 4096;
	public static immutable(int) ENET_SOCKET_WAIT_INTERRUPT = 4;
	public static immutable(int) ENET_SOCKET_WAIT_NONE = 0;
	public static immutable(int) ENET_SOCKET_WAIT_RECEIVE = 2;
	public static immutable(int) ENET_SOCKET_WAIT_SEND = 1;

	private int ENET_TIME_DIFFERENCE(int a, int b)
	{
		return a - b < 0 ? b - a : a - b;
	}

	private final bool ENET_TIME_GREATER(int a, int b)
	{
		return b - a < 0;
	}

	private bool ENET_TIME_GREATER_EQUAL(int a, int b)
	{
		return !this.ENET_TIME_LESS(a, b);
	}

	private bool ENET_TIME_LESS(int a, int b)
	{
		return a - b < 0;
	}

	private final bool ENET_TIME_LESS_EQUAL(int a, int b)
	{
		return !this.ENET_TIME_GREATER(a, b);
	}

	static int ENET_VERSION()
	{
		return ENet.ENET_VERSION_CREATE(1, 3, 8);
	}

	static int ENET_VERSION_CREATE(int major, int minor, int patch)
	{
		return major << 16 | minor << 8 | patch;
	}

	static int ENET_VERSION_GET_MAJOR(int version)
	{
		return version >> 16 & 255;
	}

	static int ENET_VERSION_GET_MINOR(int version)
	{
		return version >> 8 & 255;
	}

	static int ENET_VERSION_GET_PATCH(int version)
	{
		return version & 255;
	}
	public static immutable(int) ENET_VERSION_MAJOR = 1;
	public static immutable(int) ENET_VERSION_MINOR = 3;
	public static immutable(int) ENET_VERSION_PATCH = 8;

	private ubyte ReadByte(const(ubyte)[] currentData, int currentDataI)
	{
		return currentData[currentDataI];
	}

	private int ReadInt(const(ubyte)[] readBuf, int readPos)
	{
		int n = readBuf[readPos + 3] << 24;
		n |= readBuf[readPos + 2] << 16;
		n |= readBuf[readPos + 1] << 8;
		n |= readBuf[readPos + 0];
		return n;
	}

	private ushort ReadShort(const(ubyte)[] readBuf, int readPos)
	{
		int n = readBuf[readPos + 1] << 8;
		n |= readBuf[readPos + 0];
		readPos += 2;
		return this.p.IntToUshort(n);
	}
	public static immutable(int) SOCKET_ERROR = -1;

	private void SerializeCommand(ubyte[] buf, ENetProtocol a)
	{
		if (a == null) {
			a = new ENetProtocol;
		}
		int[] pos = new int[1];
		pos[0] = 0;
		this.WriteByte(buf, pos, a.header.command);
		this.WriteByte(buf, pos, a.header.channelID);
		this.WriteShort(buf, pos, a.header.reliableSequenceNumber);
		switch (a.header.command & 15) {
		case 1:
			{
				this.WriteShort(buf, pos, a.acknowledge.receivedReliableSequenceNumber);
				this.WriteShort(buf, pos, a.acknowledge.receivedSentTime);
				break;
			}
		case 2:
			{
				this.WriteShort(buf, pos, a.connect.outgoingPeerID);
				this.WriteByte(buf, pos, a.connect.incomingSessionID);
				this.WriteByte(buf, pos, a.connect.outgoingSessionID);
				this.WriteInt(buf, pos, a.connect.mtu);
				this.WriteInt(buf, pos, a.connect.windowSize);
				this.WriteInt(buf, pos, a.connect.channelCount);
				this.WriteInt(buf, pos, a.connect.incomingBandwidth);
				this.WriteInt(buf, pos, a.connect.outgoingBandwidth);
				this.WriteInt(buf, pos, a.connect.packetThrottleInterval);
				this.WriteInt(buf, pos, a.connect.packetThrottleAcceleration);
				this.WriteInt(buf, pos, a.connect.packetThrottleDeceleration);
				this.WriteInt(buf, pos, a.connect.connectID);
				this.WriteInt(buf, pos, a.connect.data);
				break;
			}
		case 3:
			{
				this.WriteInt(buf, pos, a.connect.outgoingPeerID);
				this.WriteByte(buf, pos, a.connect.incomingSessionID);
				this.WriteByte(buf, pos, a.connect.outgoingSessionID);
				this.WriteInt(buf, pos, a.connect.mtu);
				this.WriteInt(buf, pos, a.connect.windowSize);
				this.WriteInt(buf, pos, a.connect.channelCount);
				this.WriteInt(buf, pos, a.connect.incomingBandwidth);
				this.WriteInt(buf, pos, a.connect.outgoingBandwidth);
				this.WriteInt(buf, pos, a.connect.packetThrottleInterval);
				this.WriteInt(buf, pos, a.connect.packetThrottleAcceleration);
				this.WriteInt(buf, pos, a.connect.packetThrottleDeceleration);
				this.WriteInt(buf, pos, a.connect.connectID);
				break;
			}
		case 4:
			{
				this.WriteInt(buf, pos, a.disconnect.data);
				break;
			}
		case 5:
			{
				break;
			}
		case 6:
			{
				this.WriteShort(buf, pos, a.sendReliable.dataLength);
				break;
			}
		case 7:
			{
				this.WriteShort(buf, pos, a.sendUnreliable.unreliableSequenceNumber);
				this.WriteShort(buf, pos, a.sendUnreliable.dataLength);
				break;
			}
		case 8:
		case 12:
			{
				this.WriteShort(buf, pos, a.sendFragment.startSequenceNumber);
				this.WriteShort(buf, pos, a.sendFragment.dataLength);
				this.WriteInt(buf, pos, a.sendFragment.fragmentCount);
				this.WriteInt(buf, pos, a.sendFragment.fragmentNumber);
				this.WriteInt(buf, pos, a.sendFragment.totalLength);
				this.WriteInt(buf, pos, a.sendFragment.fragmentOffset);
				break;
			}
		case 9:
			{
				this.WriteShort(buf, pos, a.sendUnsequenced.unsequencedGroup);
				this.WriteShort(buf, pos, a.sendUnsequenced.dataLength);
				break;
			}
		case 10:
			{
				this.WriteInt(buf, pos, a.bandwidthLimit.incomingBandwidth);
				this.WriteInt(buf, pos, a.bandwidthLimit.outgoingBandwidth);
				break;
			}
		case 11:
			{
				this.WriteInt(buf, pos, a.throttleConfigure.packetThrottleInterval);
				this.WriteInt(buf, pos, a.throttleConfigure.packetThrottleAcceleration);
				this.WriteInt(buf, pos, a.throttleConfigure.packetThrottleDeceleration);
				break;
			}
		default:
			break;
		}
	}

	private void SerializeHeader(ubyte[] headerData, ENetProtocolHeader header)
	{
		int[] pos = new int[1];
		pos[0] = 0;
		this.WriteShort(headerData, pos, header.peerID);
		this.WriteShort(headerData, pos, header.sentTime);
	}

	final void SetPlatform(ENetPlatform value)
	{
		this.p = value;
	}

	static ubyte ToByte(int a)
	{
		return cast(ubyte) a;
	}

	private int ToUint16(int a)
	{
		return this.p.IntToUshort(a);
	}

	private void WriteByte(ubyte[] data, int[] pos, int value)
	{
		int pos_ = pos[0];
		data[pos_] = ENet.ToByte(value);
		pos[0] += 1;
	}

	private void WriteInt(ubyte[] data, int[] pos, int n)
	{
		int pos_ = pos[0];
		data[pos_ + 3] = ENet.ToByte(n >> 24 & 255);
		data[pos_ + 2] = ENet.ToByte(n >> 16 & 255);
		data[pos_ + 1] = ENet.ToByte(n >> 8 & 255);
		data[pos_ + 0] = ENet.ToByte(n & 255);
		pos[0] += 4;
	}

	private void WriteShort(ubyte[] data, int[] pos, int value)
	{
		int pos_ = pos[0];
		data[pos_] = ENet.ToByte(value & 255);
		data[pos_ + 1] = ENet.ToByte(value >> 8 & 255);
		pos[0] += 2;
	}

	private int commandError(ENetEvent event_)
	{
		if (event_ != null && event_.type != ENetEventType.ENET_EVENT_TYPE_NONE)
			return 1;
		return 0;
	}
	private int[] commandSizes;
	private int[] crcTable;
	private ENetIncomingCommand dummyCommand;

	final int enet_address_set_host(ENetAddress address, string hostName)
	{
		return this.p.enet_address_set_host(address, hostName);
	}

	final int enet_crc32(const(ENetBuffer)[] buffers, int bufferCount)
	{
		int crc = -1;
		if (!this.initializedCRC32)
			this.initialize_crc32();
		for (int buf = 0; buf < bufferCount; buf++) {
			const(ubyte)[] data = buffers[buf].data;
			int dataLength = buffers[buf].dataLength;
			for (int i = 0; i < dataLength; i++) {
				crc = crc >> 8 ^ this.crcTable[crc & 255 ^ data[i]];
			}
		}
		return this.p.ENET_HOST_TO_NET_32(~crc);
	}

	final void enet_deinitialize()
	{
	}

	/// Adjusts the bandwidth limits of a host.
	///
	/// @remarks the incoming and outgoing bandwidth parameters are identical in function to those
	/// specified in enet_host_create().
	/// Params:
	/// host = host to adjust
	/// incomingBandwidth = new incoming bandwidth
	/// outgoingBandwidth = new outgoing bandwidth
	final void enet_host_bandwidth_limit(ENetHost host, int incomingBandwidth, int outgoingBandwidth)
	{
		host.incomingBandwidth = incomingBandwidth;
		host.outgoingBandwidth = outgoingBandwidth;
		host.recalculateBandwidthLimits = 1;
	}

	private void enet_host_bandwidth_throttle(ENetHost host)
	{
		int timeCurrent = this.p.enet_time_get();
		int elapsedTime = timeCurrent - host.bandwidthThrottleEpoch;
		int peersRemaining = host.connectedPeers;
		int dataTotal = ~0;
		int bandwidth = ~0;
		int throttle = 0;
		int bandwidthLimit = 0;
		int needsAdjustment = host.bandwidthLimitedPeers > 0 ? 1 : 0;
		ENetPeer peer;
		ENetProtocol command = new ENetProtocol;
		if (elapsedTime < 1000)
			return;
		host.bandwidthThrottleEpoch = timeCurrent;
		if (peersRemaining == 0)
			return;
		if (host.outgoingBandwidth != 0) {
			dataTotal = 0;
			bandwidth = host.outgoingBandwidth * elapsedTime / 1000;
			for (int i = 0; i < host.peerCount; i++) {
				peer = host.peers[i];
				if (peer.state != 5 && peer.state != 6)
					continue;
				dataTotal += peer.outgoingDataTotal;
			}
		}
		while (peersRemaining > 0 && needsAdjustment != 0) {
			needsAdjustment = 0;
			if (dataTotal <= bandwidth)
				throttle = 32;
			else
				throttle = bandwidth * 32 / dataTotal;
			for (int i = 0; i < host.peerCount; i++) {
				peer = host.peers[i];
				int peerBandwidth;
				if (peer.state != 5 && peer.state != 6 || peer.incomingBandwidth == 0 || peer.outgoingBandwidthThrottleEpoch == timeCurrent)
					continue;
				peerBandwidth = peer.incomingBandwidth * elapsedTime / 1000;
				if (throttle * peer.outgoingDataTotal / 32 <= peerBandwidth)
					continue;
				peer.packetThrottleLimit = peerBandwidth * 32 / peer.outgoingDataTotal;
				if (peer.packetThrottleLimit == 0)
					peer.packetThrottleLimit = 1;
				if (peer.packetThrottle > peer.packetThrottleLimit)
					peer.packetThrottle = peer.packetThrottleLimit;
				peer.outgoingBandwidthThrottleEpoch = timeCurrent;
				peer.incomingDataTotal = 0;
				peer.outgoingDataTotal = 0;
				needsAdjustment = 1;
				peersRemaining--;
				bandwidth -= peerBandwidth;
				dataTotal -= peerBandwidth;
			}
		}
		if (peersRemaining > 0) {
			if (dataTotal <= bandwidth)
				throttle = 32;
			else
				throttle = bandwidth * 32 / dataTotal;
			for (int i = 0; i < host.peerCount; i++) {
				peer = host.peers[i];
				if (peer.state != 5 && peer.state != 6 || peer.outgoingBandwidthThrottleEpoch == timeCurrent)
					continue;
				peer.packetThrottleLimit = throttle;
				if (peer.packetThrottle > peer.packetThrottleLimit)
					peer.packetThrottle = peer.packetThrottleLimit;
				peer.incomingDataTotal = 0;
				peer.outgoingDataTotal = 0;
			}
		}
		if (host.recalculateBandwidthLimits != 0) {
			host.recalculateBandwidthLimits = 0;
			peersRemaining = host.connectedPeers;
			bandwidth = host.incomingBandwidth;
			needsAdjustment = 1;
			if (bandwidth == 0)
				bandwidthLimit = 0;
			else
				while (peersRemaining > 0 && needsAdjustment != 0) {
					needsAdjustment = 0;
					bandwidthLimit = bandwidth / peersRemaining;
					for (int i = 0; i < host.peerCount; i++) {
						peer = host.peers[i];
						if (peer.state != 5 && peer.state != 6 || peer.incomingBandwidthThrottleEpoch == timeCurrent)
							continue;
						if (peer.outgoingBandwidth > 0 && peer.outgoingBandwidth >= bandwidthLimit)
							continue;
						peer.incomingBandwidthThrottleEpoch = timeCurrent;
						needsAdjustment = 1;
						peersRemaining--;
						bandwidth -= peer.outgoingBandwidth;
					}
				}
			for (int i = 0; i < host.peerCount; i++) {
				peer = host.peers[i];
				if (peer.state != 5 && peer.state != 6)
					continue;
				command.header.command = 138;
				command.header.channelID = 255;
				command.bandwidthLimit = new ENetProtocolBandwidthLimit;
				command.bandwidthLimit.outgoingBandwidth = this.p.ENET_HOST_TO_NET_32(host.outgoingBandwidth);
				if (peer.incomingBandwidthThrottleEpoch == timeCurrent)
					command.bandwidthLimit.incomingBandwidth = this.p.ENET_HOST_TO_NET_32(peer.outgoingBandwidth);
				else
					command.bandwidthLimit.incomingBandwidth = this.p.ENET_HOST_TO_NET_32(bandwidthLimit);
				this.enet_peer_queue_outgoing_command(peer, command, null, 0, 0);
			}
		}
	}

	/// Queues a packet to be sent to all peers associated with the host.
	/// Params:
	/// host = host on which to broadcast the packet
	/// channelID = channel on which to broadcast
	/// packet = packet to broadcast
	final void enet_host_broadcast(ENetHost host, ubyte channelID, ENetPacket packet)
	{
		ENetPeer currentPeer;
		for (int i = 0; i < host.peerCount; i++) {
			currentPeer = host.peers[i];
			if (currentPeer.state != 5)
				continue;
			this.enet_peer_send(currentPeer, channelID, packet);
		}
		if (packet.referenceCount == 0)
			this.enet_packet_destroy(packet);
	}

	/// Limits the maximum allowed channels of future incoming connections.
	/// Params:
	/// host = host to limit
	/// channelLimit = the maximum number of channels allowed; if 0, then this is equivalent to ENET_PROTOCOL_MAXIMUM_CHANNEL_COUNT
	final void enet_host_channel_limit(ENetHost host, int channelLimit)
	{
		if (channelLimit == 0 || channelLimit > 255)
			channelLimit = 255;
		else if (channelLimit < 1)
			channelLimit = 1;
		host.channelLimit = channelLimit;
	}

	/// Checks for any queued events on the host and dispatches one if available.
	///
	/// @retval &gt; 0 if an event was dispatched
	/// @retval 0 if no events are available
	/// @retval &lt; 0 on failure
	/// @ingroup host
	/// Params:
	/// host = host to check for events
	/// event_ = an event structure where event details will be placed if available
	final int enet_host_check_events(ENetHost host, ENetEvent event_)
	{
		if (event_ == null)
			return -1;
		event_.type = ENetEventType.ENET_EVENT_TYPE_NONE;
		event_.peer = null;
		event_.packet = null;
		return this.enet_protocol_dispatch_incoming_commands(host, event_);
	}

	/// Sets the packet compressor the host should use to compress and decompress packets.
	/// Params:
	/// host = host to enable or disable compression for
	/// compressor = callbacks for for the packet compressor; if NULL, then compression is disabled
	final void enet_host_compress(ENetHost host, ENetCompressor compressor)
	{
		if (host.compressor != null)
			host.compressor.destroy();
		if (compressor != null)
			host.compressor = compressor;
		else
			host.compressor = null;
	}

	/// Sets the packet compressor the host should use to the default range coder.
	///
	/// @returns 0 on success, &lt; 0 on failure
	/// Params:
	/// host = @param host host to enable the range coder for
	final int enet_host_compress_with_range_coder(ENetHost host)
	{
		return 0;
	}

	/// Initiates a connection to a foreign host.
	///
	/// @returns a peer representing the foreign host on success, NULL on failure
	/// @remarks The peer returned will have not completed the connection until enet_host_service()
	/// notifies of an ENET_EVENT_TYPE_CONNECT event for the peer.
	/// Params:
	/// host = host seeking the connection
	/// address = destination for the connection
	/// channelCount = number of channels to allocate
	/// data = user data supplied to the receiving host 
	final ENetPeer enet_host_connect(ENetHost host, ENetAddress address, int channelCount, int data)
	{
		ENetPeer currentPeer = null;
		ENetChannel channel;
		ENetProtocol command = new ENetProtocol;
		if (channelCount < 1)
			channelCount = 1;
		else if (channelCount > 255)
			channelCount = 255;
		for (int i = 0; i < host.peerCount; i++) {
			currentPeer = host.peers[i];
			if (currentPeer.state == 0)
				break;
		}
		if (host.peerCount == 0) {
			return null;
		}
		currentPeer.channels = new ENetChannel[channelCount];
		for (int i = 0; i < channelCount; i++) {
			currentPeer.channels[i] = new ENetChannel;
		}
		if (currentPeer.channels == null)
			return null;
		currentPeer.channelCount = channelCount;
		currentPeer.state = 1;
		currentPeer.address = ENetAddress.Clone(address);
		currentPeer.connectID = ++host.randomSeed;
		if (host.outgoingBandwidth == 0)
			currentPeer.windowSize = 32768;
		else
			currentPeer.windowSize = host.outgoingBandwidth / 65536 * 4096;
		if (currentPeer.windowSize < 4096)
			currentPeer.windowSize = 4096;
		else if (currentPeer.windowSize > 32768)
			currentPeer.windowSize = 32768;
		for (int i = 0; i < channelCount; i++) {
			channel = currentPeer.channels[i];
			channel.outgoingReliableSequenceNumber = 0;
			channel.outgoingUnreliableSequenceNumber = 0;
			channel.incomingReliableSequenceNumber = 0;
			channel.incomingUnreliableSequenceNumber = 0;
			this.enet_list_clear(channel.incomingReliableCommands);
			this.enet_list_clear(channel.incomingUnreliableCommands);
			channel.usedReliableWindows = 0;
			for (int k = 0; k < 16; k++) {
				channel.reliableWindows[k] = 0;
			}
		}
		command.header = new ENetProtocolCommandHeader;
		command.header.command = 130;
		command.header.channelID = 255;
		command.connect = new ENetProtocolConnect;
		command.connect.outgoingPeerID = this.p.ENET_HOST_TO_NET_16(currentPeer.incomingPeerID);
		command.connect.incomingSessionID = currentPeer.incomingSessionID;
		command.connect.outgoingSessionID = currentPeer.outgoingSessionID;
		command.connect.mtu = this.p.ENET_HOST_TO_NET_32(currentPeer.mtu);
		command.connect.windowSize = this.p.ENET_HOST_TO_NET_32(currentPeer.windowSize);
		command.connect.channelCount = this.p.ENET_HOST_TO_NET_32(channelCount);
		command.connect.incomingBandwidth = this.p.ENET_HOST_TO_NET_32(host.incomingBandwidth);
		command.connect.outgoingBandwidth = this.p.ENET_HOST_TO_NET_32(host.outgoingBandwidth);
		command.connect.packetThrottleInterval = this.p.ENET_HOST_TO_NET_32(currentPeer.packetThrottleInterval);
		command.connect.packetThrottleAcceleration = this.p.ENET_HOST_TO_NET_32(currentPeer.packetThrottleAcceleration);
		command.connect.packetThrottleDeceleration = this.p.ENET_HOST_TO_NET_32(currentPeer.packetThrottleDeceleration);
		command.connect.connectID = currentPeer.connectID;
		command.connect.data = this.p.ENET_HOST_TO_NET_32(data);
		this.enet_peer_queue_outgoing_command(currentPeer, command, null, 0, 0);
		return currentPeer;
	}

	/// Creates a host for communicating to peers.  
	/// @remarks ENet will strategically drop packets on specific sides of a connection between hosts
	/// to ensure the host's bandwidth is not overwhelmed.  The bandwidth parameters also determine
	/// the window size of a connection which limits the amount of reliable packets that may be in transit
	/// at any given time.
	///
	/// @returns the host on success and NULL on failure
	/// Params:
	/// address = the address at which other peers may connect to this host.  If NULL, then no peers may connect to the host.
	/// peerCount = the maximum number of peers that should be allocated for the host.
	/// channelLimit = the maximum number of channels allowed; if 0, then this is equivalent to ENET_PROTOCOL_MAXIMUM_CHANNEL_COUNT
	/// incomingBandwidth = downstream bandwidth of the host in bytes/second; if 0, ENet will assume unlimited bandwidth.
	/// outgoingBandwidth = upstream bandwidth of the host in bytes/second; if 0, ENet will assume unlimited bandwidth.
	final ENetHost enet_host_create(ENetAddress address, int peerCount, int channelLimit, int incomingBandwidth, int outgoingBandwidth)
	{
		ENetHost host;
		ENetPeer currentPeer;
		if (peerCount > 4095)
			return null;
		host = new ENetHost;
		if (host == null)
			return null;
		host.peers = new ENetPeer[peerCount];
		if (host.peers == null) {
			return null;
		}
		for (int i = 0; i < peerCount; i++) {
			host.peers[i] = new ENetPeer;
		}
		host.socket = this.p.enet_socket_create(2);
		if (host.socket != null && host.socket.NULL() || address != null && this.p.enet_socket_bind(host.socket, address) < 0) {
			if (host.socket != null && !host.socket.NULL())
				this.p.enet_socket_destroy(host.socket);
			return null;
		}
		this.p.enet_socket_set_option(host.socket, 1, 1);
		this.p.enet_socket_set_option(host.socket, 2, 1);
		this.p.enet_socket_set_option(host.socket, 3, 262144);
		this.p.enet_socket_set_option(host.socket, 4, 262144);
		if (address != null && this.p.enet_socket_get_address(host.socket, host.address) < 0)
			host.address = address;
		if (channelLimit == 0 || channelLimit > 255)
			channelLimit = 255;
		else if (channelLimit < 1)
			channelLimit = 1;
		host.randomSeed = 0;
		host.randomSeed += this.p.time();
		host.randomSeed = host.randomSeed << 16 | host.randomSeed >> 16;
		host.channelLimit = channelLimit;
		host.incomingBandwidth = incomingBandwidth;
		host.outgoingBandwidth = outgoingBandwidth;
		host.bandwidthThrottleEpoch = 0;
		host.recalculateBandwidthLimits = 0;
		host.mtu = 1400;
		host.peerCount = peerCount;
		host.commandCount = 0;
		host.bufferCount = 0;
		host.checksum = null;
		host.receivedAddress = new ENetAddress;
		host.receivedAddress.host = 0;
		host.receivedAddress.port = 0;
		host.receivedData = null;
		host.receivedDataLength = 0;
		host.totalSentData = 0;
		host.totalSentPackets = 0;
		host.totalReceivedData = 0;
		host.totalReceivedPackets = 0;
		host.connectedPeers = 0;
		host.bandwidthLimitedPeers = 0;
		host.compressor = null;
		host.intercept = null;
		host.dispatchQueue = new ENetPeer;
		host.dispatchQueue.SetSentinel(new ENetPeer);
		this.enet_list_clear(host.dispatchQueue);
		for (int i = 0; i < host.peerCount; i++) {
			currentPeer = host.peers[i];
			currentPeer.host = host;
			currentPeer.incomingPeerID = this.p.IntToUshort(i);
			currentPeer.outgoingSessionID = currentPeer.incomingSessionID = 255;
			currentPeer.data = null;
			this.enet_list_clear(currentPeer.acknowledgements);
			this.enet_list_clear(currentPeer.sentReliableCommands);
			this.enet_list_clear(currentPeer.sentUnreliableCommands);
			this.enet_list_clear(currentPeer.outgoingReliableCommands);
			this.enet_list_clear(currentPeer.outgoingUnreliableCommands);
			this.enet_list_clear(currentPeer.dispatchedCommands);
			this.enet_peer_reset(currentPeer);
		}
		return host;
	}

	/// Destroys the host and all resources associated with it.
	/// Params:
	/// host = pointer to the host to destroy
	final void enet_host_destroy(ENetHost host)
	{
		ENetPeer currentPeer;
		if (host == null)
			return;
		this.p.enet_socket_destroy(host.socket);
		for (int i = 0; i < host.peerCount; i++) {
			currentPeer = host.peers[i];
			this.enet_peer_reset(currentPeer);
		}
		if (host.compressor != null)
			host.compressor.destroy();
	}

	/// Sends any queued packets on the host specified to its designated peers.
	///
	/// @remarks this function need only be used in circumstances where one wishes to send queued packets earlier than in a call to enet_host_service().
	/// @ingroup host
	/// Params:
	/// host = host to flush
	final void enet_host_flush(ENetHost host)
	{
		host.serviceTime = this.p.enet_time_get();
		this.enet_protocol_send_outgoing_commands(host, null, 0);
	}

	/// Waits for events on the host specified and shuttles packets between the host and its peers.
	///
	/// enet_host_service should be called fairly regularly for adequate performance
	/// @ingroup host
	/// @retval &gt; 0 if an event occurred within the specified time limit
	/// @retval 0 if no event occurred
	/// @retval &lt; 0 on failure
	/// Params:
	/// host = host to service
	/// event_ = an event structure where event details will be placed if one occurs
	/// if event == null then no events will be delivered
	/// timeout = number of milliseconds that ENet should wait for events
	final int enet_host_service(ENetHost host, ENetEvent event_, int timeout)
	{
		int[] waitCondition = new int[1];
		if (event_ != null) {
			event_.type = ENetEventType.ENET_EVENT_TYPE_NONE;
			event_.peer = null;
			event_.packet = null;
			switch (this.enet_protocol_dispatch_incoming_commands(host, event_)) {
			case 1:
				return 1;
			case -1:
				return -1;
			default:
				break;
			}
		}
		host.serviceTime = this.p.enet_time_get();
		timeout += host.serviceTime;
		do {
			if (this.ENET_TIME_DIFFERENCE(host.serviceTime, host.bandwidthThrottleEpoch) >= 1000)
				this.enet_host_bandwidth_throttle(host);
			switch (this.enet_protocol_send_outgoing_commands(host, event_, 1)) {
			case 1:
				return 1;
			case -1:
				return -1;
			default:
				break;
			}
			switch (this.enet_protocol_receive_incoming_commands(host, event_)) {
			case 1:
				return 1;
			case -1:
				return -1;
			default:
				break;
			}
			switch (this.enet_protocol_send_outgoing_commands(host, event_, 1)) {
			case 1:
				return 1;
			case -1:
				return -1;
			default:
				break;
			}
			if (event_ != null) {
				switch (this.enet_protocol_dispatch_incoming_commands(host, event_)) {
				case 1:
					return 1;
				case -1:
					return -1;
				default:
					break;
				}
			}
			do {
				host.serviceTime = this.p.enet_time_get();
				if (this.ENET_TIME_GREATER_EQUAL(host.serviceTime, timeout))
					return 0;
				waitCondition[0] = 6;
				if (this.p.enet_socket_wait(host.socket, waitCondition, this.ENET_TIME_DIFFERENCE(timeout, host.serviceTime)) != 0)
					return -1;
			}
			while ((waitCondition[0] & 4) != 0);
			host.serviceTime = this.p.enet_time_get();
		}
		while ((waitCondition[0] & 2) != 0);
		return 0;
	}

	final int enet_initialize()
	{
		return 0;
	}

	private final ENetListNode enet_list_back(ENetList list)
	{
		return this.p.CastToENetListNode(this.p.CastToENetListNode(list.GetSentinel()).previous);
	}

	private ENetListNode enet_list_begin(ENetList list)
	{
		return this.p.CastToENetListNode(this.p.CastToENetListNode(list.GetSentinel()).next);
	}

	private void enet_list_clear(ENetList list)
	{
		this.p.CastToENetListNode(list.GetSentinel()).next = list.GetSentinel();
		this.p.CastToENetListNode(list.GetSentinel()).previous = list.GetSentinel();
	}

	private bool enet_list_empty(ENetList list)
	{
		return this.enet_list_begin(list) == this.enet_list_end(list);
	}

	private ENetListNode enet_list_end(ENetList list)
	{
		return this.p.CastToENetListNode(list.GetSentinel());
	}

	private ENetListNode enet_list_front(ENetList list)
	{
		return this.p.CastToENetListNode(this.p.CastToENetListNode(list.GetSentinel()).next);
	}

	private ENetListNode enet_list_insert(ENetListNode position, ENetObject data)
	{
		ENetListNode result = this.p.CastToENetListNode(data);
		result.previous = position.previous;
		result.next = position;
		this.p.CastToENetListNode(result.previous).next = result;
		position.previous = result;
		return result;
	}

	private ENetListNode enet_list_move(ENetListNode position, ENetListNode dataFirst, ENetListNode dataLast)
	{
		ENetListNode first = dataFirst;
		ENetListNode last = dataLast;
		this.p.CastToENetListNode(first.previous).next = last.next;
		this.p.CastToENetListNode(last.next).previous = first.previous;
		first.previous = position.previous;
		last.next = position;
		this.p.CastToENetListNode(first.previous).next = first;
		position.previous = last;
		return first;
	}

	private ENetListNode enet_list_next(ENetListNode iterator)
	{
		return this.p.CastToENetListNode(iterator.next);
	}

	private ENetListNode enet_list_previous(ENetListNode iterator)
	{
		return this.p.CastToENetListNode(iterator.previous);
	}

	private ENetListNode enet_list_remove(ENetListNode position)
	{
		this.p.CastToENetListNode(position.previous).next = position.next;
		this.p.CastToENetListNode(position.next).previous = position.previous;
		return position;
	}

	private final int enet_list_size(ENetList list)
	{
		int size = 0;
		ENetListNode position;
		for (position = this.enet_list_begin(list); position != this.enet_list_end(list); position = this.enet_list_next(position))
			size++;
		return size;
	}

	/// Creates a packet that may be sent to a peer.
	///
	/// @returns the packet on success, NULL on failure
	/// Params:
	/// data = initial contents of the packet's data; the packet's data will remain uninitialized if dataContents is NULL.
	/// dataLength = size of the data allocated for this packet
	/// flags = flags for this packet as described for the ENetPacket structure.
	final ENetPacket enet_packet_create(ubyte[] data, int dataLength, int flags)
	{
		ENetPacket packet = new ENetPacket;
		if (packet == null)
			return null;
		if ((flags & 4) != 0)
			packet.data = data;
		else if (dataLength <= 0)
			packet.data = null;
		else {
			packet.data = new ubyte[dataLength];
			if (packet.data == null) {
				return null;
			}
			if (data != null) {
				for (int i = 0; i < dataLength; i++) {
					packet.data[i] = data[i];
				}
			}
		}
		packet.referenceCount = 0;
		packet.flags = flags;
		packet.dataLength = dataLength;
		packet.freeCallback = null;
		packet.userData = null;
		return packet;
	}

	/// Destroys the packet and deallocates its data.
	/// Params:
	/// packet = packet to be destroyed
	final void enet_packet_destroy(ENetPacket packet)
	{
		if (packet == null)
			return;
		if (packet.freeCallback != null)
			packet.freeCallback.Run(packet);
		if ((packet.flags & 4) == 0 && packet.data != null) {
		}
	}

	final int enet_packet_resize(ENetPacket packet, int dataLength)
	{
		ubyte[] newData;
		if (dataLength <= packet.dataLength || (packet.flags & 4) != 0) {
			packet.dataLength = dataLength;
			return 0;
		}
		newData = new ubyte[dataLength];
		if (newData == null)
			return -1;
		this.memcpy(newData, packet.data, packet.dataLength);
		packet.data = newData;
		packet.dataLength = dataLength;
		return 0;
	}

	/// Request a disconnection from a peer.
	///
	/// An ENET_EVENT_DISCONNECT event will be generated by enet_host_service()
	/// once the disconnection is complete.
	/// Params:
	/// peer = peer to request a disconnection
	/// data = data describing the disconnection
	final void enet_peer_disconnect(ENetPeer peer, int data)
	{
		ENetProtocol command = new ENetProtocol;
		if (peer.state == 7 || peer.state == 0 || peer.state == 8 || peer.state == 9)
			return;
		this.enet_peer_reset_queues(peer);
		command.header.command = 4;
		command.header.channelID = 255;
		command.disconnect.data = this.p.ENET_HOST_TO_NET_32(data);
		if (peer.state == 5 || peer.state == 6)
			command.header.command |= 128;
		else
			command.header.command |= 64;
		this.enet_peer_queue_outgoing_command(peer, command, null, 0, 0);
		if (peer.state == 5 || peer.state == 6) {
			this.enet_peer_on_disconnect(peer);
			peer.state = 7;
		}
		else {
			this.enet_host_flush(peer.host);
			this.enet_peer_reset(peer);
		}
	}

	/// Request a disconnection from a peer, but only after all queued outgoing packets are sent.
	///
	/// An ENET_EVENT_DISCONNECT event will be generated by enet_host_service()
	/// once the disconnection is complete.
	/// Params:
	/// peer = peer to request a disconnection
	/// data = data describing the disconnection
	final void enet_peer_disconnect_later(ENetPeer peer, int data)
	{
		if ((peer.state == 5 || peer.state == 6) && !(this.enet_list_empty(peer.outgoingReliableCommands) && this.enet_list_empty(peer.outgoingUnreliableCommands) && this.enet_list_empty(peer.sentReliableCommands))) {
			peer.state = 6;
			peer.eventData = data;
		}
		else
			this.enet_peer_disconnect(peer, data);
	}

	/// Force an immediate disconnection from a peer.
	///
	/// @remarks No ENET_EVENT_DISCONNECT event will be generated. The foreign peer is not
	/// guarenteed to receive the disconnect notification, and is reset immediately upon
	/// return from this function.
	/// Params:
	/// peer = peer to disconnect
	/// data = data describing the disconnection
	final void enet_peer_disconnect_now(ENetPeer peer, int data)
	{
		ENetProtocol command = new ENetProtocol;
		if (peer.state == 0)
			return;
		if (peer.state != 9 && peer.state != 7) {
			this.enet_peer_reset_queues(peer);
			command.header.command = 68;
			command.header.channelID = 255;
			command.disconnect.data = this.p.ENET_HOST_TO_NET_32(data);
			this.enet_peer_queue_outgoing_command(peer, command, null, 0, 0);
			this.enet_host_flush(peer.host);
		}
		this.enet_peer_reset(peer);
	}

	private void enet_peer_dispatch_incoming_reliable_commands(ENetPeer peer, ENetChannel channel)
	{
		ENetListNode currentCommand;
		for (currentCommand = this.enet_list_begin(channel.incomingReliableCommands); currentCommand != this.enet_list_end(channel.incomingReliableCommands); currentCommand = this.enet_list_next(currentCommand)) {
			ENetIncomingCommand incomingCommand = this.p.CastToENetIncomingCommand(currentCommand);
			if (incomingCommand.fragmentsRemaining > 0 || incomingCommand.reliableSequenceNumber != this.p.IntToUshort(channel.incomingReliableSequenceNumber + 1))
				break;
			channel.incomingReliableSequenceNumber = incomingCommand.reliableSequenceNumber;
			if (incomingCommand.fragmentCount > 0)
				channel.incomingReliableSequenceNumber += incomingCommand.fragmentCount - 1;
		}
		if (currentCommand == this.enet_list_begin(channel.incomingReliableCommands))
			return;
		channel.incomingUnreliableSequenceNumber = 0;
		this.enet_list_move(this.enet_list_end(peer.dispatchedCommands), this.enet_list_begin(channel.incomingReliableCommands), this.enet_list_previous(currentCommand));
		if (peer.needsDispatch == 0) {
			this.enet_list_insert(this.enet_list_end(peer.host.dispatchQueue), peer.dispatchList());
			peer.needsDispatch = 1;
		}
		if (!this.enet_list_empty(channel.incomingUnreliableCommands))
			this.enet_peer_dispatch_incoming_unreliable_commands(peer, channel);
	}

	private void enet_peer_dispatch_incoming_unreliable_commands(ENetPeer peer, ENetChannel channel)
	{
		ENetListNode droppedCommand;
		ENetListNode startCommand;
		ENetListNode currentCommand;
		for (droppedCommand = startCommand = currentCommand = this.enet_list_begin(channel.incomingUnreliableCommands); currentCommand != this.enet_list_end(channel.incomingUnreliableCommands); currentCommand = this.enet_list_next(currentCommand)) {
			ENetIncomingCommand incomingCommand = this.p.CastToENetIncomingCommand(currentCommand);
			if ((incomingCommand.command.header.command & 15) == 9)
				continue;
			if (incomingCommand.reliableSequenceNumber == channel.incomingReliableSequenceNumber) {
				if (incomingCommand.fragmentsRemaining <= 0) {
					channel.incomingUnreliableSequenceNumber = incomingCommand.unreliableSequenceNumber;
					continue;
				}
				if (startCommand != currentCommand) {
					this.enet_list_move(this.enet_list_end(peer.dispatchedCommands), startCommand, this.enet_list_previous(currentCommand));
					if (peer.needsDispatch == 0) {
						this.enet_list_insert(this.enet_list_end(peer.host.dispatchQueue), peer.dispatchList());
						peer.needsDispatch = 1;
					}
					droppedCommand = currentCommand;
				}
				else if (droppedCommand != currentCommand)
					droppedCommand = this.enet_list_previous(currentCommand);
			}
			else {
				ushort reliableWindow = this.p.IntToUshort(incomingCommand.reliableSequenceNumber / 4096);
				ushort currentWindow = this.p.IntToUshort(channel.incomingReliableSequenceNumber / 4096);
				if (incomingCommand.reliableSequenceNumber < channel.incomingReliableSequenceNumber)
					reliableWindow += 16;
				if (reliableWindow >= currentWindow && reliableWindow < currentWindow + 8 - 1)
					break;
				droppedCommand = this.enet_list_next(currentCommand);
				if (startCommand != currentCommand) {
					this.enet_list_move(this.enet_list_end(peer.dispatchedCommands), startCommand, this.enet_list_previous(currentCommand));
					if (peer.needsDispatch == 0) {
						this.enet_list_insert(this.enet_list_end(peer.host.dispatchQueue), peer.dispatchList());
						peer.needsDispatch = 1;
					}
				}
			}
			startCommand = this.enet_list_next(currentCommand);
		}
		if (startCommand != currentCommand) {
			this.enet_list_move(this.enet_list_end(peer.dispatchedCommands), startCommand, this.enet_list_previous(currentCommand));
			if (peer.needsDispatch == 0) {
				this.enet_list_insert(this.enet_list_end(peer.host.dispatchQueue), peer.dispatchList());
				peer.needsDispatch = 1;
			}
			droppedCommand = currentCommand;
		}
		this.enet_peer_remove_incoming_commands(channel.incomingUnreliableCommands, this.enet_list_begin(channel.incomingUnreliableCommands), droppedCommand);
	}

	private void enet_peer_on_connect(ENetPeer peer)
	{
		if (peer.state != 5 && peer.state != 6) {
			if (peer.incomingBandwidth != 0)
				peer.host.bandwidthLimitedPeers++;
			peer.host.connectedPeers++;
		}
	}

	private void enet_peer_on_disconnect(ENetPeer peer)
	{
		if (peer.state == 5 || peer.state == 6) {
			if (peer.incomingBandwidth != 0)
				peer.host.bandwidthLimitedPeers--;
			peer.host.connectedPeers--;
		}
	}

	/// Sends a ping request to a peer.
	///
	/// ping requests factor into the mean round trip time as designated by the 
	/// roundTripTime field in the ENetPeer structure.  Enet automatically pings all connected
	/// peers at regular intervals, however, this function may be called to ensure more
	/// frequent ping requests.
	/// Params:
	/// peer = destination for the ping request
	final void enet_peer_ping(ENetPeer peer)
	{
		ENetProtocol command = new ENetProtocol;
		if (peer.state != 5)
			return;
		command.header.command = 133;
		command.header.channelID = 255;
		this.enet_peer_queue_outgoing_command(peer, command, null, 0, 0);
	}

	/// Sets the interval at which pings will be sent to a peer. 
	/// Pings are used both to monitor the liveness of the connection and also to dynamically
	/// adjust the throttle during periods of low traffic so that the throttle has reasonable
	/// responsiveness during traffic spikes.
	/// Params:
	/// peer = the peer to adjust
	/// pingInterval = the interval at which to send pings; defaults to ENET_PEER_PING_INTERVAL if 0
	final void enet_peer_ping_interval(ENetPeer peer, int pingInterval)
	{
		peer.pingInterval = pingInterval != 0 ? pingInterval : 500;
	}

	private ENetAcknowledgement enet_peer_queue_acknowledgement(ENetPeer peer, ENetProtocol command, ushort sentTime)
	{
		ENetAcknowledgement acknowledgement;
		if (command.header.channelID < peer.channelCount) {
			ENetChannel channel = peer.channels[command.header.channelID];
			ushort reliableWindow = this.p.IntToUshort(command.header.reliableSequenceNumber / 4096);
			ushort currentWindow = this.p.IntToUshort(channel.incomingReliableSequenceNumber / 4096);
			if (command.header.reliableSequenceNumber < channel.incomingReliableSequenceNumber)
				reliableWindow += 16;
			if (reliableWindow >= currentWindow + 8 - 1 && reliableWindow <= currentWindow + 8)
				return null;
		}
		acknowledgement = new ENetAcknowledgement;
		if (acknowledgement == null)
			return null;
		peer.outgoingDataTotal += 8;
		acknowledgement.sentTime = sentTime;
		acknowledgement.command = command;
		this.enet_list_insert(this.enet_list_end(peer.acknowledgements), acknowledgement);
		return acknowledgement;
	}

	private ENetIncomingCommand enet_peer_queue_incoming_command(ENetPeer peer, ENetProtocol command, ENetPacket packet, int fragmentCount)
	{
		ENetChannel channel = peer.channels[command.header.channelID];
		int unreliableSequenceNumber = 0;
		int reliableSequenceNumber = 0;
		int reliableWindow;
		int currentWindow;
		ENetIncomingCommand incomingCommand = null;
		ENetListNode currentCommand;
		if (peer.state == 6) {
			return this.freePacket(fragmentCount, packet);
		}
		if ((command.header.command & 15) != 9) {
			reliableSequenceNumber = command.header.reliableSequenceNumber;
			reliableWindow = reliableSequenceNumber / 4096;
			currentWindow = channel.incomingReliableSequenceNumber / 4096;
			if (reliableSequenceNumber < channel.incomingReliableSequenceNumber)
				reliableWindow += 16;
			if (reliableWindow < currentWindow || reliableWindow >= currentWindow + 8 - 1) {
				return this.freePacket(fragmentCount, packet);
			}
		}
		switch (command.header.command & 15) {
		case 8:
		case 6:
			if (reliableSequenceNumber == channel.incomingReliableSequenceNumber)
				return this.freePacket(fragmentCount, packet);
			for (currentCommand = this.enet_list_previous(this.enet_list_end(channel.incomingReliableCommands)); currentCommand != this.enet_list_end(channel.incomingReliableCommands); currentCommand = this.enet_list_previous(currentCommand)) {
				incomingCommand = this.p.CastToENetIncomingCommand(currentCommand);
				if (reliableSequenceNumber >= channel.incomingReliableSequenceNumber) {
					if (incomingCommand.reliableSequenceNumber < channel.incomingReliableSequenceNumber)
						continue;
				}
				else if (incomingCommand.reliableSequenceNumber >= channel.incomingReliableSequenceNumber)
					break;
				if (incomingCommand.reliableSequenceNumber <= reliableSequenceNumber) {
					if (incomingCommand.reliableSequenceNumber < reliableSequenceNumber)
						break;
					return this.freePacket(fragmentCount, packet);
				}
			}
			break;
		case 7:
		case 12:
			unreliableSequenceNumber = this.p.ENET_NET_TO_HOST_16(command.sendUnreliable.unreliableSequenceNumber);
			if (reliableSequenceNumber == channel.incomingReliableSequenceNumber && unreliableSequenceNumber <= channel.incomingUnreliableSequenceNumber)
				return this.freePacket(fragmentCount, packet);
			for (currentCommand = this.enet_list_previous(this.enet_list_end(channel.incomingUnreliableCommands)); currentCommand != this.enet_list_end(channel.incomingUnreliableCommands); currentCommand = this.enet_list_previous(currentCommand)) {
				incomingCommand = this.p.CastToENetIncomingCommand(currentCommand);
				if ((command.header.command & 15) == 9)
					continue;
				if (reliableSequenceNumber >= channel.incomingReliableSequenceNumber) {
					if (incomingCommand.reliableSequenceNumber < channel.incomingReliableSequenceNumber)
						continue;
				}
				else if (incomingCommand.reliableSequenceNumber >= channel.incomingReliableSequenceNumber)
					break;
				if (incomingCommand.reliableSequenceNumber < reliableSequenceNumber)
					break;
				if (incomingCommand.reliableSequenceNumber > reliableSequenceNumber)
					continue;
				if (incomingCommand.unreliableSequenceNumber <= unreliableSequenceNumber) {
					if (incomingCommand.unreliableSequenceNumber < unreliableSequenceNumber)
						break;
					return this.freePacket(fragmentCount, packet);
				}
			}
			break;
		case 9:
			currentCommand = this.enet_list_end(channel.incomingUnreliableCommands);
			break;
		default:
			return this.freePacket(fragmentCount, packet);
		}
		incomingCommand = new ENetIncomingCommand;
		if (incomingCommand == null)
			return this.notifyError(packet);
		incomingCommand.reliableSequenceNumber = command.header.reliableSequenceNumber;
		incomingCommand.unreliableSequenceNumber = this.p.IntToUshort(unreliableSequenceNumber & 65535);
		incomingCommand.command = command;
		incomingCommand.fragmentCount = fragmentCount;
		incomingCommand.fragmentsRemaining = fragmentCount;
		incomingCommand.packet = packet;
		incomingCommand.fragments = null;
		if (fragmentCount > 0) {
			if (fragmentCount <= 1048576)
				incomingCommand.fragments = new int[(fragmentCount + 31) / 32];
			if (incomingCommand.fragments == null) {
				return this.notifyError(packet);
			}
			for (int i = 0; i < (fragmentCount + 31) / 32; i++) {
				incomingCommand.fragments[i] = 0;
			}
		}
		if (packet != null)
			packet.referenceCount++;
		this.enet_list_insert(this.enet_list_next(currentCommand), incomingCommand);
		switch (command.header.command & 15) {
		case 8:
		case 6:
			this.enet_peer_dispatch_incoming_reliable_commands(peer, channel);
			break;
		default:
			this.enet_peer_dispatch_incoming_unreliable_commands(peer, channel);
			break;
		}
		return incomingCommand;
	}

	private ENetOutgoingCommand enet_peer_queue_outgoing_command(ENetPeer peer, ENetProtocol command, ENetPacket packet, int offset, ushort length)
	{
		ENetOutgoingCommand outgoingCommand = new ENetOutgoingCommand;
		if (outgoingCommand == null)
			return null;
		outgoingCommand.command = command;
		outgoingCommand.fragmentOffset = offset;
		outgoingCommand.fragmentLength = length;
		outgoingCommand.packet = packet;
		if (packet != null)
			packet.referenceCount++;
		this.enet_peer_setup_outgoing_command(peer, outgoingCommand);
		return outgoingCommand;
	}

	/// Attempts to dequeue any incoming queued packet.
	///
	/// @returns a pointer to the packet, or NULL if there are no available incoming queued packets
	/// Params:
	/// peer = peer to dequeue packets from
	/// channelID = holds the channel ID of the channel the packet was received on success
	final ENetPacket enet_peer_receive(ENetPeer peer, Byte channelID)
	{
		ENetIncomingCommand incomingCommand;
		ENetPacket packet;
		if (this.enet_list_empty(peer.dispatchedCommands))
			return null;
		incomingCommand = this.p.CastToENetIncomingCommand(this.enet_list_remove(this.enet_list_begin(peer.dispatchedCommands)));
		if (channelID != null)
			channelID.value = incomingCommand.command.header.channelID;
		packet = incomingCommand.packet;
		packet.referenceCount--;
		if (incomingCommand.fragments != null) {
		}
		return packet;
	}

	final void enet_peer_remove_incoming_commands(ENetList queue, ENetListNode startCommand, ENetListNode endCommand)
	{
		ENetListNode currentCommand;
		for (currentCommand = startCommand; currentCommand != endCommand;) {
			ENetIncomingCommand incomingCommand = this.p.CastToENetIncomingCommand(currentCommand);
			currentCommand = this.enet_list_next(currentCommand);
			this.enet_list_remove(incomingCommand.incomingCommandList());
			if (incomingCommand.packet != null) {
				incomingCommand.packet.referenceCount--;
				if (incomingCommand.packet.referenceCount == 0)
					this.enet_packet_destroy(incomingCommand.packet);
			}
			if (incomingCommand.fragments != null) {
			}
		}
	}

	/// Forcefully disconnects a peer.
	///
	/// The foreign host represented by the peer is not notified of the disconnection and will timeout
	/// on its connection to the local host.
	/// Params:
	/// peer = peer to forcefully disconnect
	final void enet_peer_reset(ENetPeer peer)
	{
		this.enet_peer_on_disconnect(peer);
		peer.outgoingPeerID = 4095;
		peer.connectID = 0;
		peer.state = 0;
		peer.incomingBandwidth = 0;
		peer.outgoingBandwidth = 0;
		peer.incomingBandwidthThrottleEpoch = 0;
		peer.outgoingBandwidthThrottleEpoch = 0;
		peer.incomingDataTotal = 0;
		peer.outgoingDataTotal = 0;
		peer.lastSendTime = 0;
		peer.lastReceiveTime = 0;
		peer.nextTimeout = 0;
		peer.earliestTimeout = 0;
		peer.packetLossEpoch = 0;
		peer.packetsSent = 0;
		peer.packetsLost = 0;
		peer.packetLoss = 0;
		peer.packetLossVariance = 0;
		peer.packetThrottle = 32;
		peer.packetThrottleLimit = 32;
		peer.packetThrottleCounter = 0;
		peer.packetThrottleEpoch = 0;
		peer.packetThrottleAcceleration = 2;
		peer.packetThrottleDeceleration = 2;
		peer.packetThrottleInterval = 5000;
		peer.pingInterval = 500;
		peer.timeoutLimit = 32;
		peer.timeoutMinimum = 5000;
		peer.timeoutMaximum = 30000;
		peer.lastRoundTripTime = 500;
		peer.lowestRoundTripTime = 500;
		peer.lastRoundTripTimeVariance = 0;
		peer.highestRoundTripTimeVariance = 0;
		peer.roundTripTime = 500;
		peer.roundTripTimeVariance = 0;
		peer.mtu = peer.host.mtu;
		peer.reliableDataInTransit = 0;
		peer.outgoingReliableSequenceNumber = 0;
		peer.windowSize = 32768;
		peer.incomingUnsequencedGroup = 0;
		peer.outgoingUnsequencedGroup = 0;
		peer.eventData = 0;
		for (int i = 0; i < 32; i++) {
			peer.unsequencedWindow[i] = 0;
		}
		this.enet_peer_reset_queues(peer);
	}

	final void enet_peer_reset_incoming_commands(ENetList queue)
	{
		this.enet_peer_remove_incoming_commands(queue, this.enet_list_begin(queue), this.enet_list_end(queue));
	}

	final void enet_peer_reset_outgoing_commands(ENetList queue)
	{
		ENetOutgoingCommand outgoingCommand;
		while (!this.enet_list_empty(queue)) {
			outgoingCommand = this.p.CastToENetOutgoingCommand(this.enet_list_remove(this.enet_list_begin(queue)));
			if (outgoingCommand.packet != null) {
				outgoingCommand.packet.referenceCount--;
				if (outgoingCommand.packet.referenceCount == 0)
					this.enet_packet_destroy(outgoingCommand.packet);
			}
		}
	}

	final void enet_peer_reset_queues(ENetPeer peer)
	{
		ENetChannel channel;
		if (peer.needsDispatch != 0) {
			this.enet_list_remove(peer.dispatchList());
			peer.needsDispatch = 0;
		}
		while (!this.enet_list_empty(peer.acknowledgements)) {
			ENetListNode n = this.enet_list_remove(this.enet_list_begin(peer.acknowledgements));
		}
		this.enet_peer_reset_outgoing_commands(peer.sentReliableCommands);
		this.enet_peer_reset_outgoing_commands(peer.sentUnreliableCommands);
		this.enet_peer_reset_outgoing_commands(peer.outgoingReliableCommands);
		this.enet_peer_reset_outgoing_commands(peer.outgoingUnreliableCommands);
		this.enet_peer_reset_incoming_commands(peer.dispatchedCommands);
		if (peer.channels != null && peer.channelCount > 0) {
			for (int i = 0; i < peer.channelCount; i++) {
				channel = peer.channels[i];
				this.enet_peer_reset_incoming_commands(channel.incomingReliableCommands);
				this.enet_peer_reset_incoming_commands(channel.incomingUnreliableCommands);
			}
		}
		peer.channels = null;
		peer.channelCount = 0;
	}

	/// Queues a packet to be sent.
	///
	/// @retval 0 on success
	/// @retval &lt; 0 on failure
	/// Params:
	/// peer = destination for the packet
	/// channelID = channel on which to send
	/// packet = packet to send
	final int enet_peer_send(ENetPeer peer, ubyte channelID, ENetPacket packet)
	{
		ENetChannel channel = peer.channels[channelID];
		ENetProtocol command = new ENetProtocol;
		int fragmentLength;
		if (peer.state != 5 || channelID >= peer.channelCount || packet.dataLength > 1073741824)
			return -1;
		fragmentLength = peer.mtu - 4 - 28;
		if (peer.host.checksum != null)
			fragmentLength -= 4;
		if (packet.dataLength > fragmentLength) {
			int fragmentCount = (packet.dataLength + fragmentLength - 1) / fragmentLength;
			int fragmentNumber;
			int fragmentOffset;
			ubyte commandNumber;
			ushort startSequenceNumber;
			ENetList fragments = null;
			ENetOutgoingCommand fragment;
			if (fragmentCount > 1048576)
				return -1;
			if ((packet.flags & 9) == 8 && channel.outgoingUnreliableSequenceNumber < 65535) {
				commandNumber = 12;
				startSequenceNumber = this.p.ENET_HOST_TO_NET_16(this.p.IntToUshort(channel.outgoingUnreliableSequenceNumber + 1));
			}
			else {
				commandNumber = 136;
				startSequenceNumber = this.p.ENET_HOST_TO_NET_16(this.p.IntToUshort(channel.outgoingReliableSequenceNumber + 1));
			}
			this.enet_list_clear(fragments);
			fragmentNumber = 0;
			fragmentOffset = 0;
			while (fragmentOffset < packet.dataLength) {
				if (packet.dataLength - fragmentOffset < fragmentLength)
					fragmentLength = packet.dataLength - fragmentOffset;
				fragment = new ENetOutgoingCommand;
				if (fragment == null) {
					while (!this.enet_list_empty(fragments)) {
						fragment = this.p.CastToENetOutgoingCommand(this.enet_list_remove(this.enet_list_begin(fragments)).data);
					}
					return -1;
				}
				fragment.fragmentOffset = fragmentOffset;
				fragment.fragmentLength = this.p.IntToUshort(fragmentLength);
				fragment.packet = packet;
				fragment.command.header.command = commandNumber;
				fragment.command.header.channelID = channelID;
				fragment.command.sendFragment.startSequenceNumber = startSequenceNumber;
				fragment.command.sendFragment.dataLength = this.p.ENET_HOST_TO_NET_16(this.p.IntToUshort(fragmentLength));
				fragment.command.sendFragment.fragmentCount = this.p.ENET_HOST_TO_NET_32(fragmentCount);
				fragment.command.sendFragment.fragmentNumber = this.p.ENET_HOST_TO_NET_32(fragmentNumber);
				fragment.command.sendFragment.totalLength = this.p.ENET_HOST_TO_NET_32(packet.dataLength);
				fragment.command.sendFragment.fragmentOffset = this.p.ENET_NET_TO_HOST_32(fragmentOffset);
				this.enet_list_insert(this.enet_list_end(fragments), fragment);
				fragmentNumber++;
				fragmentOffset += fragmentLength;
			}
			packet.referenceCount += fragmentNumber;
			while (!this.enet_list_empty(fragments)) {
				fragment = this.p.CastToENetOutgoingCommand(this.enet_list_remove(this.enet_list_begin(fragments)));
				this.enet_peer_setup_outgoing_command(peer, fragment);
			}
			return 0;
		}
		command.header.channelID = channelID;
		if ((packet.flags & 3) == 2) {
			command.header.command = 73;
			command.sendUnsequenced.dataLength = this.p.ENET_HOST_TO_NET_16(this.p.IntToUshort(packet.dataLength));
		}
		else if ((packet.flags & 1) != 0 || channel.outgoingUnreliableSequenceNumber >= 65535) {
			command.header.command = 134;
			command.sendReliable = new ENetProtocolSendReliable;
			command.sendReliable.dataLength = this.p.ENET_HOST_TO_NET_16(this.p.IntToUshort(packet.dataLength));
		}
		else {
			command.header.command = 7;
			command.sendUnreliable = new ENetProtocolSendUnreliable;
			command.sendUnreliable.dataLength = this.p.ENET_HOST_TO_NET_16(this.p.IntToUshort(packet.dataLength));
		}
		if (this.enet_peer_queue_outgoing_command(peer, command, packet, 0, this.p.IntToUshort(packet.dataLength)) == null)
			return -1;
		return 0;
	}

	final void enet_peer_setup_outgoing_command(ENetPeer peer, ENetOutgoingCommand outgoingCommand)
	{
		ENetChannel channel = null;
		peer.outgoingDataTotal += this.enet_protocol_command_size(outgoingCommand.command.header.command) + outgoingCommand.fragmentLength;
		if (outgoingCommand.command.header.channelID == 255) {
			peer.outgoingReliableSequenceNumber++;
			outgoingCommand.reliableSequenceNumber = peer.outgoingReliableSequenceNumber;
			outgoingCommand.unreliableSequenceNumber = 0;
		}
		else {
			channel = peer.channels[outgoingCommand.command.header.channelID];
			if ((outgoingCommand.command.header.command & 128) != 0) {
				channel.outgoingReliableSequenceNumber++;
				channel.outgoingUnreliableSequenceNumber = 0;
				outgoingCommand.reliableSequenceNumber = channel.outgoingReliableSequenceNumber;
				outgoingCommand.unreliableSequenceNumber = 0;
			}
			else if ((outgoingCommand.command.header.command & 64) != 0) {
				peer.outgoingUnsequencedGroup++;
				outgoingCommand.reliableSequenceNumber = 0;
				outgoingCommand.unreliableSequenceNumber = 0;
			}
			else {
				if (outgoingCommand.fragmentOffset == 0)
					channel.outgoingUnreliableSequenceNumber++;
				outgoingCommand.reliableSequenceNumber = channel.outgoingReliableSequenceNumber;
				outgoingCommand.unreliableSequenceNumber = channel.outgoingUnreliableSequenceNumber;
			}
		}
		outgoingCommand.sendAttempts = 0;
		outgoingCommand.sentTime = 0;
		outgoingCommand.roundTripTimeout = 0;
		outgoingCommand.roundTripTimeoutLimit = 0;
		outgoingCommand.command.header.reliableSequenceNumber = this.p.ENET_HOST_TO_NET_16(outgoingCommand.reliableSequenceNumber);
		switch (outgoingCommand.command.header.command & 15) {
		case 7:
			outgoingCommand.command.sendUnreliable.unreliableSequenceNumber = this.p.ENET_HOST_TO_NET_16(outgoingCommand.unreliableSequenceNumber);
			break;
		case 9:
			outgoingCommand.command.sendUnsequenced.unsequencedGroup = this.p.ENET_HOST_TO_NET_16(peer.outgoingUnsequencedGroup);
			break;
		default:
			break;
		}
		if ((outgoingCommand.command.header.command & 128) != 0)
			this.enet_list_insert(this.enet_list_end(peer.outgoingReliableCommands), outgoingCommand);
		else
			this.enet_list_insert(this.enet_list_end(peer.outgoingUnreliableCommands), outgoingCommand);
	}

	private int enet_peer_throttle(ENetPeer peer, int rtt)
	{
		if (peer.lastRoundTripTime <= peer.lastRoundTripTimeVariance) {
			peer.packetThrottle = peer.packetThrottleLimit;
		}
		else if (rtt < peer.lastRoundTripTime) {
			peer.packetThrottle += peer.packetThrottleAcceleration;
			if (peer.packetThrottle > peer.packetThrottleLimit)
				peer.packetThrottle = peer.packetThrottleLimit;
			return 1;
		}
		else if (rtt > peer.lastRoundTripTime + 2 * peer.lastRoundTripTimeVariance) {
			if (peer.packetThrottle > peer.packetThrottleDeceleration)
				peer.packetThrottle -= peer.packetThrottleDeceleration;
			else
				peer.packetThrottle = 0;
			return -1;
		}
		return 0;
	}

	/// @defgroup peer ENet peer functions 
	/// Configures throttle parameter for a peer.
	///
	/// Unreliable packets are dropped by ENet in response to the varying conditions
	/// of the Internet connection to the peer.  The throttle represents a probability
	/// that an unreliable packet should not be dropped and thus sent by ENet to the peer.
	/// The lowest mean round trip time from the sending of a reliable packet to the
	/// receipt of its acknowledgement is measured over an amount of time specified by
	/// the interval parameter in milliseconds.  If a measured round trip time happens to
	/// be significantly less than the mean round trip time measured over the interval, 
	/// then the throttle probability is increased to allow more traffic by an amount
	/// specified in the acceleration parameter, which is a ratio to the ENET_PEER_PACKET_THROTTLE_SCALE
	/// constant.  If a measured round trip time happens to be significantly greater than
	/// the mean round trip time measured over the interval, then the throttle probability
	/// is decreased to limit traffic by an amount specified in the deceleration parameter, which
	/// is a ratio to the ENET_PEER_PACKET_THROTTLE_SCALE constant.  When the throttle has
	/// a value of ENET_PEER_PACKET_THROTTLE_SCALE, no unreliable packets are dropped by 
	/// ENet, and so 100% of all unreliable packets will be sent.  When the throttle has a
	/// value of 0, all unreliable packets are dropped by ENet, and so 0% of all unreliable
	/// packets will be sent.  Intermediate values for the throttle represent intermediate
	/// probabilities between 0% and 100% of unreliable packets being sent.  The bandwidth
	/// limits of the local and foreign hosts are taken into account to determine a 
	/// sensible limit for the throttle probability above which it should not raise even in
	/// the best of conditions.
	/// Params:
	/// peer = peer to configure 
	/// interval = interval, in milliseconds, over which to measure lowest mean RTT; the default value is ENET_PEER_PACKET_THROTTLE_INTERVAL.
	/// acceleration = rate at which to increase the throttle probability as mean RTT declines
	/// deceleration = rate at which to decrease the throttle probability as mean RTT increases
	final void enet_peer_throttle_configure(ENetPeer peer, int interval, int acceleration, int deceleration)
	{
		ENetProtocol command = new ENetProtocol;
		peer.packetThrottleInterval = interval;
		peer.packetThrottleAcceleration = acceleration;
		peer.packetThrottleDeceleration = deceleration;
		command.header.command = 139;
		command.header.channelID = 255;
		command.throttleConfigure.packetThrottleInterval = this.p.ENET_HOST_TO_NET_32(interval);
		command.throttleConfigure.packetThrottleAcceleration = this.p.ENET_HOST_TO_NET_32(acceleration);
		command.throttleConfigure.packetThrottleDeceleration = this.p.ENET_HOST_TO_NET_32(deceleration);
		this.enet_peer_queue_outgoing_command(peer, command, null, 0, 0);
	}

	/// Sets the timeout parameters for a peer.
	///
	/// The timeout parameter control how and when a peer will timeout from a failure to acknowledge
	/// reliable traffic. Timeout values use an exponential backoff mechanism, where if a reliable
	/// packet is not acknowledge within some multiple of the average RTT plus a variance tolerance, 
	/// the timeout will be doubled until it reaches a set limit. If the timeout is thus at this
	/// limit and reliable packets have been sent but not acknowledged within a certain minimum time 
	/// period, the peer will be disconnected. Alternatively, if reliable packets have been sent
	/// but not acknowledged for a certain maximum time period, the peer will be disconnected regardless
	/// of the current timeout limit value.
	/// Params:
	/// peer = the peer to adjust
	/// timeoutLimit = the timeout limit; defaults to ENET_PEER_TIMEOUT_LIMIT if 0
	/// timeoutMinimum = the timeout minimum; defaults to ENET_PEER_TIMEOUT_MINIMUM if 0
	/// timeoutMaximum = the timeout maximum; defaults to ENET_PEER_TIMEOUT_MAXIMUM if 0
	final void enet_peer_timeout(ENetPeer peer, int timeoutLimit, int timeoutMinimum, int timeoutMaximum)
	{
		peer.timeoutLimit = timeoutLimit != 0 ? timeoutLimit : 32;
		peer.timeoutMinimum = timeoutMinimum != 0 ? timeoutMinimum : 5000;
		peer.timeoutMaximum = timeoutMaximum != 0 ? timeoutMaximum : 30000;
	}

	final void enet_protocol_change_state(ENetHost host, ENetPeer peer, int state)
	{
		if (state == 5 || state == 6)
			this.enet_peer_on_connect(peer);
		else
			this.enet_peer_on_disconnect(peer);
		peer.state = state;
	}

	final int enet_protocol_check_timeouts(ENetHost host, ENetPeer peer, ENetEvent event_)
	{
		ENetOutgoingCommand outgoingCommand = null;
		ENetListNode currentCommand;
		ENetListNode insertPosition;
		currentCommand = this.enet_list_begin(peer.sentReliableCommands);
		insertPosition = this.enet_list_begin(peer.outgoingReliableCommands);
		while (currentCommand != this.enet_list_end(peer.sentReliableCommands)) {
			outgoingCommand = this.p.CastToENetOutgoingCommand(currentCommand);
			currentCommand = this.enet_list_next(currentCommand);
			if (this.ENET_TIME_DIFFERENCE(host.serviceTime, outgoingCommand.sentTime) < outgoingCommand.roundTripTimeout)
				continue;
			if (peer.earliestTimeout == 0 || this.ENET_TIME_LESS(outgoingCommand.sentTime, peer.earliestTimeout))
				peer.earliestTimeout = outgoingCommand.sentTime;
			if (peer.earliestTimeout != 0 && (this.ENET_TIME_DIFFERENCE(host.serviceTime, peer.earliestTimeout) >= peer.timeoutMaximum || outgoingCommand.roundTripTimeout >= outgoingCommand.roundTripTimeoutLimit && this.ENET_TIME_DIFFERENCE(host.serviceTime, peer.earliestTimeout) >= peer.timeoutMinimum)) {
				this.enet_protocol_notify_disconnect(host, peer, event_);
				return 1;
			}
			if (outgoingCommand.packet != null)
				peer.reliableDataInTransit -= outgoingCommand.fragmentLength;
			peer.packetsLost++;
			outgoingCommand.roundTripTimeout *= 2;
			this.enet_list_insert(insertPosition, this.enet_list_remove(outgoingCommand.outgoingCommandList()));
			if (currentCommand == this.enet_list_begin(peer.sentReliableCommands) && !this.enet_list_empty(peer.sentReliableCommands)) {
				outgoingCommand = this.p.CastToENetOutgoingCommand(currentCommand);
				peer.nextTimeout = outgoingCommand.sentTime + outgoingCommand.roundTripTimeout;
			}
		}
		return 0;
	}

	private int enet_protocol_command_size(ubyte commandNumber)
	{
		return this.commandSizes[commandNumber & 15];
	}

	final int enet_protocol_dispatch_incoming_commands(ENetHost host, ENetEvent event_)
	{
		while (!this.enet_list_empty(host.dispatchQueue)) {
			ENetPeer peer = this.p.CastToENetPeer(this.enet_list_remove(this.enet_list_begin(host.dispatchQueue)));
			peer.needsDispatch = 0;
			switch (peer.state) {
			case 3:
			case 4:
				this.enet_protocol_change_state(host, peer, 5);
				event_.type = ENetEventType.ENET_EVENT_TYPE_CONNECT;
				event_.peer = peer;
				event_.data = peer.eventData;
				return 1;
			case 9:
				host.recalculateBandwidthLimits = 1;
				event_.type = ENetEventType.ENET_EVENT_TYPE_DISCONNECT;
				event_.peer = peer;
				event_.data = peer.eventData;
				this.enet_peer_reset(peer);
				return 1;
			case 5:
				if (this.enet_list_empty(peer.dispatchedCommands))
					continue;
				Byte b = new Byte;
				b.value = event_.channelID;
				event_.packet = this.enet_peer_receive(peer, b);
				event_.channelID = b.value;
				if (event_.packet == null)
					continue;
				event_.type = ENetEventType.ENET_EVENT_TYPE_RECEIVE;
				event_.peer = peer;
				if (!this.enet_list_empty(peer.dispatchedCommands)) {
					peer.needsDispatch = 1;
					this.enet_list_insert(this.enet_list_end(host.dispatchQueue), peer.dispatchList());
				}
				return 1;
			default:
				break;
			}
		}
		return 0;
	}

	final void enet_protocol_dispatch_state(ENetHost host, ENetPeer peer, int state)
	{
		this.enet_protocol_change_state(host, peer, state);
		if (peer.needsDispatch == 0) {
			this.enet_list_insert(this.enet_list_end(host.dispatchQueue), peer.dispatchList());
			peer.needsDispatch = 1;
		}
	}

	final int enet_protocol_handle_acknowledge(ENetHost host, ENetEvent event_, ENetPeer peer, ENetProtocol command)
	{
		int roundTripTime;
		int receivedSentTime;
		int receivedReliableSequenceNumber;
		int commandNumber;
		if (peer.state == 0 || peer.state == 9)
			return 0;
		receivedSentTime = this.p.ENET_NET_TO_HOST_16(command.acknowledge.receivedSentTime);
		receivedSentTime |= host.serviceTime & -65536;
		if ((receivedSentTime & 32768) > (host.serviceTime & 32768))
			receivedSentTime -= 65536;
		if (this.ENET_TIME_LESS(host.serviceTime, receivedSentTime))
			return 0;
		peer.lastReceiveTime = host.serviceTime;
		peer.earliestTimeout = 0;
		roundTripTime = this.ENET_TIME_DIFFERENCE(host.serviceTime, receivedSentTime);
		this.enet_peer_throttle(peer, roundTripTime);
		peer.roundTripTimeVariance -= peer.roundTripTimeVariance / 4;
		if (roundTripTime >= peer.roundTripTime) {
			peer.roundTripTime += (roundTripTime - peer.roundTripTime) / 8;
			peer.roundTripTimeVariance += (roundTripTime - peer.roundTripTime) / 4;
		}
		else {
			peer.roundTripTime -= (peer.roundTripTime - roundTripTime) / 8;
			peer.roundTripTimeVariance += (peer.roundTripTime - roundTripTime) / 4;
		}
		if (peer.roundTripTime < peer.lowestRoundTripTime)
			peer.lowestRoundTripTime = peer.roundTripTime;
		if (peer.roundTripTimeVariance > peer.highestRoundTripTimeVariance)
			peer.highestRoundTripTimeVariance = peer.roundTripTimeVariance;
		if (peer.packetThrottleEpoch == 0 || this.ENET_TIME_DIFFERENCE(host.serviceTime, peer.packetThrottleEpoch) >= peer.packetThrottleInterval) {
			peer.lastRoundTripTime = peer.lowestRoundTripTime;
			peer.lastRoundTripTimeVariance = peer.highestRoundTripTimeVariance;
			peer.lowestRoundTripTime = peer.roundTripTime;
			peer.highestRoundTripTimeVariance = peer.roundTripTimeVariance;
			peer.packetThrottleEpoch = host.serviceTime;
		}
		receivedReliableSequenceNumber = this.p.ENET_NET_TO_HOST_16(command.acknowledge.receivedReliableSequenceNumber);
		commandNumber = this.enet_protocol_remove_sent_reliable_command(peer, this.p.IntToUshort(receivedReliableSequenceNumber), command.header.channelID);
		switch (peer.state) {
		case 2:
			if (commandNumber != 3)
				return -1;
			this.enet_protocol_notify_connect(host, peer, event_);
			break;
		case 7:
			if (commandNumber != 4)
				return -1;
			this.enet_protocol_notify_disconnect(host, peer, event_);
			break;
		case 6:
			if (this.enet_list_empty(peer.outgoingReliableCommands) && this.enet_list_empty(peer.outgoingUnreliableCommands) && this.enet_list_empty(peer.sentReliableCommands))
				this.enet_peer_disconnect(peer, peer.eventData);
			break;
		default:
			break;
		}
		return 0;
	}

	final int enet_protocol_handle_bandwidth_limit(ENetHost host, ENetPeer peer, ENetProtocol command)
	{
		if (peer.state != 5 && peer.state != 6)
			return -1;
		if (peer.incomingBandwidth != 0)
			host.bandwidthLimitedPeers--;
		peer.incomingBandwidth = this.p.ENET_NET_TO_HOST_32(command.bandwidthLimit.incomingBandwidth);
		peer.outgoingBandwidth = this.p.ENET_NET_TO_HOST_32(command.bandwidthLimit.outgoingBandwidth);
		if (peer.incomingBandwidth != 0)
			host.bandwidthLimitedPeers++;
		if (peer.incomingBandwidth == 0 && host.outgoingBandwidth == 0)
			peer.windowSize = 32768;
		else
			peer.windowSize = this.ENET_MIN(peer.incomingBandwidth, host.outgoingBandwidth) / 65536 * 4096;
		if (peer.windowSize < 4096)
			peer.windowSize = 4096;
		else if (peer.windowSize > 32768)
			peer.windowSize = 32768;
		return 0;
	}

	final ENetPeer enet_protocol_handle_connect(ENetHost host, ENetProtocolHeader header, ENetProtocol command)
	{
		ubyte incomingSessionID;
		ubyte outgoingSessionID;
		int mtu;
		int windowSize;
		ENetChannel channel;
		int channelCount;
		ENetPeer currentPeer = new ENetPeer;
		ENetProtocol verifyCommand = new ENetProtocol;
		channelCount = this.p.ENET_NET_TO_HOST_32(command.connect.channelCount);
		if (channelCount < 1 || channelCount > 255)
			return null;
		int i;
		for (i = 0; i < host.peerCount; i++) {
			currentPeer = host.peers[i];
			if (currentPeer.state != 0 && currentPeer.address.host == host.receivedAddress.host && currentPeer.address.port == host.receivedAddress.port && currentPeer.connectID == command.connect.connectID)
				return null;
		}
		for (i = 0; i < host.peerCount; i++) {
			currentPeer = host.peers[i];
			if (currentPeer.state == 0)
				break;
		}
		if (i >= host.peerCount)
			return null;
		if (channelCount > host.channelLimit)
			channelCount = host.channelLimit;
		currentPeer.channels = new ENetChannel[channelCount];
		for (int k = 0; k < channelCount; k++) {
			currentPeer.channels[k] = new ENetChannel;
		}
		if (currentPeer.channels == null)
			return null;
		currentPeer.channelCount = channelCount;
		currentPeer.state = 2;
		currentPeer.connectID = command.connect.connectID;
		currentPeer.address = host.receivedAddress;
		currentPeer.outgoingPeerID = this.p.ENET_NET_TO_HOST_16(command.connect.outgoingPeerID);
		currentPeer.incomingBandwidth = this.p.ENET_NET_TO_HOST_32(command.connect.incomingBandwidth);
		currentPeer.outgoingBandwidth = this.p.ENET_NET_TO_HOST_32(command.connect.outgoingBandwidth);
		currentPeer.packetThrottleInterval = this.p.ENET_NET_TO_HOST_32(command.connect.packetThrottleInterval);
		currentPeer.packetThrottleAcceleration = this.p.ENET_NET_TO_HOST_32(command.connect.packetThrottleAcceleration);
		currentPeer.packetThrottleDeceleration = this.p.ENET_NET_TO_HOST_32(command.connect.packetThrottleDeceleration);
		currentPeer.eventData = this.p.ENET_NET_TO_HOST_32(command.connect.data);
		incomingSessionID = command.connect.incomingSessionID == 255 ? currentPeer.outgoingSessionID : command.connect.incomingSessionID;
		incomingSessionID = ENet.ToByte(incomingSessionID + 1 & 3);
		if (incomingSessionID == currentPeer.outgoingSessionID)
			incomingSessionID = ENet.ToByte(incomingSessionID + 1 & 3);
		currentPeer.outgoingSessionID = incomingSessionID;
		outgoingSessionID = command.connect.outgoingSessionID == 255 ? currentPeer.incomingSessionID : command.connect.outgoingSessionID;
		outgoingSessionID = ENet.ToByte(outgoingSessionID + 1 & 3);
		if (outgoingSessionID == currentPeer.incomingSessionID)
			outgoingSessionID = ENet.ToByte(outgoingSessionID + 1 & 3);
		currentPeer.incomingSessionID = outgoingSessionID;
		for (i = 0; i < currentPeer.channelCount; i++) {
			channel = currentPeer.channels[i];
			channel.outgoingReliableSequenceNumber = 0;
			channel.outgoingUnreliableSequenceNumber = 0;
			channel.incomingReliableSequenceNumber = 0;
			channel.incomingUnreliableSequenceNumber = 0;
			this.enet_list_clear(channel.incomingReliableCommands);
			this.enet_list_clear(channel.incomingUnreliableCommands);
			channel.usedReliableWindows = 0;
			for (int k = 0; k < 16; k++) {
				channel.reliableWindows[k] = 0;
			}
		}
		mtu = this.p.ENET_NET_TO_HOST_32(command.connect.mtu);
		if (mtu < 576)
			mtu = 576;
		else if (mtu > 4096)
			mtu = 4096;
		currentPeer.mtu = mtu;
		if (host.outgoingBandwidth == 0 && currentPeer.incomingBandwidth == 0)
			currentPeer.windowSize = 32768;
		else if (host.outgoingBandwidth == 0 || currentPeer.incomingBandwidth == 0)
			currentPeer.windowSize = this.ENET_MAX(host.outgoingBandwidth, currentPeer.incomingBandwidth) / 65536 * 4096;
		else
			currentPeer.windowSize = this.ENET_MIN(host.outgoingBandwidth, currentPeer.incomingBandwidth) / 65536 * 4096;
		if (currentPeer.windowSize < 4096)
			currentPeer.windowSize = 4096;
		else if (currentPeer.windowSize > 32768)
			currentPeer.windowSize = 32768;
		if (host.incomingBandwidth == 0)
			windowSize = 32768;
		else
			windowSize = host.incomingBandwidth / 65536 * 4096;
		if (windowSize > this.p.ENET_NET_TO_HOST_32(command.connect.windowSize))
			windowSize = this.p.ENET_NET_TO_HOST_32(command.connect.windowSize);
		if (windowSize < 4096)
			windowSize = 4096;
		else if (windowSize > 32768)
			windowSize = 32768;
		verifyCommand.header = new ENetProtocolCommandHeader;
		verifyCommand.header.command = 131;
		verifyCommand.header.channelID = 255;
		verifyCommand.verifyConnect = new ENetProtocolVerifyConnect;
		verifyCommand.verifyConnect.outgoingPeerID = this.p.ENET_HOST_TO_NET_16(currentPeer.incomingPeerID);
		verifyCommand.verifyConnect.incomingSessionID = incomingSessionID;
		verifyCommand.verifyConnect.outgoingSessionID = outgoingSessionID;
		verifyCommand.verifyConnect.mtu = this.p.ENET_HOST_TO_NET_32(currentPeer.mtu);
		verifyCommand.verifyConnect.windowSize = this.p.ENET_HOST_TO_NET_32(windowSize);
		verifyCommand.verifyConnect.channelCount = this.p.ENET_HOST_TO_NET_32(channelCount);
		verifyCommand.verifyConnect.incomingBandwidth = this.p.ENET_HOST_TO_NET_32(host.incomingBandwidth);
		verifyCommand.verifyConnect.outgoingBandwidth = this.p.ENET_HOST_TO_NET_32(host.outgoingBandwidth);
		verifyCommand.verifyConnect.packetThrottleInterval = this.p.ENET_HOST_TO_NET_32(currentPeer.packetThrottleInterval);
		verifyCommand.verifyConnect.packetThrottleAcceleration = this.p.ENET_HOST_TO_NET_32(currentPeer.packetThrottleAcceleration);
		verifyCommand.verifyConnect.packetThrottleDeceleration = this.p.ENET_HOST_TO_NET_32(currentPeer.packetThrottleDeceleration);
		verifyCommand.verifyConnect.connectID = currentPeer.connectID;
		this.enet_peer_queue_outgoing_command(currentPeer, verifyCommand, null, 0, 0);
		return currentPeer;
	}

	final int enet_protocol_handle_disconnect(ENetHost host, ENetPeer peer, ENetProtocol command)
	{
		if (peer.state == 0 || peer.state == 9 || peer.state == 8)
			return 0;
		this.enet_peer_reset_queues(peer);
		if (peer.state == 4 || peer.state == 7)
			this.enet_protocol_dispatch_state(host, peer, 9);
		else if (peer.state != 5 && peer.state != 6) {
			if (peer.state == 3)
				host.recalculateBandwidthLimits = 1;
			this.enet_peer_reset(peer);
		}
		else if ((command.header.command & 128) != 0)
			this.enet_protocol_change_state(host, peer, 8);
		else
			this.enet_protocol_dispatch_state(host, peer, 9);
		if (peer.state != 0)
			peer.eventData = this.p.ENET_NET_TO_HOST_32(command.disconnect.data);
		return 0;
	}

	final int enet_protocol_handle_incoming_commands(ENetHost host, ENetEvent event_)
	{
		ENetProtocolHeader header;
		ENetProtocol command = null;
		ENetPeer peer;
		const(ubyte)[] currentData = null;
		int headerSize = 0;
		ushort peerID;
		ushort flags;
		int sessionID;
		int[] currentDataI = new int[1];
		currentDataI[0] = 0;
		header = this.Deserialize(host.receivedData);
		peerID = this.ENET_NET_TO_HOST_16(header.peerID);
		sessionID = (peerID & 12288) >> 12;
		flags = this.p.IntToUshort(peerID & 49152);
		peerID &= this.p.IntToUshort(~61440);
		headerSize = (flags & 32768) != 0 ? 4 : 2;
		if (host.checksum != null)
			headerSize += 4;
		if (peerID == 4095)
			peer = null;
		else if (peerID >= host.peerCount)
			return 0;
		else {
			peer = host.peers[peerID];
			if (peer.state == 0 || peer.state == 9 || (host.receivedAddress.host != peer.address.host || host.receivedAddress.port != peer.address.port) && peer.address.host != -1 || peer.outgoingPeerID < 4095 && sessionID != peer.incomingSessionID)
				return 0;
		}
		if ((flags & 16384) != 0) {
			int originalSize = 0;
			if (host.compressor == null)
				return 0;
			for (int i = 0; i < headerSize; i++) {
			}
			host.receivedData = host.packetData[1];
			host.receivedDataLength = headerSize + originalSize;
		}
		if (host.checksum != null) {
			int checksum = 0;
			int desiredChecksum = checksum;
			ENetBuffer buffer = new ENetBuffer;
			checksum = peer != null ? peer.connectID : 0;
			buffer.data = host.receivedData;
			buffer.dataLength = host.receivedDataLength;
			if (host.checksum.Run(buffer, 1) != desiredChecksum)
				return 0;
		}
		if (peer != null) {
			peer.address.host = host.receivedAddress.host;
			peer.address.port = host.receivedAddress.port;
			peer.incomingDataTotal += host.receivedDataLength;
		}
		currentDataI[0] += headerSize;
		int test = 0;
		while (currentDataI[0] < host.receivedDataLength) {
			ubyte commandNumber;
			int commandSize;
			if (test > 0) {
			}
			test++;
			if (currentDataI[0] + 4 > host.receivedDataLength)
				break;
			command = this.DeserializeProtocolCommandHeader(host.receivedData, currentDataI[0]);
			commandNumber = ENet.ToByte(command.header.command & 15);
			if (commandNumber == 0) {
			}
			if (commandNumber >= 13)
				break;
			commandSize = this.commandSizes[commandNumber];
			if (commandSize == 0 || currentDataI[0] + commandSize > host.receivedDataLength)
				break;
			this.DeserializeProtocolCommandCommand(host.receivedData, currentDataI[0], commandNumber, command);
			currentDataI[0] += commandSize;
			if (peer == null && commandNumber != 2)
				break;
			command.header.reliableSequenceNumber = this.ENET_NET_TO_HOST_16(command.header.reliableSequenceNumber);
			if (this.test1 == 1) {
			}
			if (command.header.reliableSequenceNumber == 1) {
				this.test1++;
			}
			switch (commandNumber) {
			case 1:
				if (this.enet_protocol_handle_acknowledge(host, event_, peer, command) != 0)
					return this.commandError(event_);
				break;
			case 2:
				if (peer != null)
					return this.commandError(event_);
				peer = this.enet_protocol_handle_connect(host, header, command);
				if (peer == null)
					return this.commandError(event_);
				break;
			case 3:
				if (this.enet_protocol_handle_verify_connect(host, event_, peer, command) != 0)
					return this.commandError(event_);
				break;
			case 4:
				if (this.enet_protocol_handle_disconnect(host, peer, command) != 0)
					return this.commandError(event_);
				break;
			case 5:
				if (this.enet_protocol_handle_ping(host, peer, command) != 0)
					return this.commandError(event_);
				break;
			case 6:
				if (this.enet_protocol_handle_send_reliable(host, peer, command, host.receivedData, currentDataI) != 0)
					return this.commandError(event_);
				break;
			case 7:
				if (this.enet_protocol_handle_send_unreliable(host, peer, command, host.receivedData, currentDataI) != 0)
					return this.commandError(event_);
				break;
			case 9:
				if (this.enet_protocol_handle_send_unsequenced(host, peer, command, currentData) != 0)
					return this.commandError(event_);
				break;
			case 8:
				if (this.enet_protocol_handle_send_fragment(host, peer, command, host.receivedData, currentDataI) != 0)
					return this.commandError(event_);
				break;
			case 10:
				if (this.enet_protocol_handle_bandwidth_limit(host, peer, command) != 0)
					return this.commandError(event_);
				break;
			case 11:
				if (this.enet_protocol_handle_throttle_configure(host, peer, command) != 0)
					return this.commandError(event_);
				break;
			case 12:
				if (this.enet_protocol_handle_send_unreliable_fragment(host, peer, command, currentData) != 0)
					return this.commandError(event_);
				break;
			default:
				return this.commandError(event_);
			}
			if (peer != null && (command.header.command & 128) != 0) {
				ushort sentTime;
				if ((flags & 32768) == 0)
					break;
				sentTime = this.ENET_NET_TO_HOST_16(header.sentTime);
				switch (peer.state) {
				case 7:
				case 2:
				case 0:
				case 9:
					break;
				case 8:
					if ((command.header.command & 15) == 4)
						this.enet_peer_queue_acknowledgement(peer, command, sentTime);
					break;
				default:
					this.enet_peer_queue_acknowledgement(peer, command, sentTime);
					break;
				}
			}
		}
		if (event_ != null && event_.type != ENetEventType.ENET_EVENT_TYPE_NONE) {
			return 1;
		}
		return 0;
	}

	final int enet_protocol_handle_ping(ENetHost host, ENetPeer peer, ENetProtocol command)
	{
		if (peer.state != 5 && peer.state != 6)
			return -1;
		return 0;
	}

	final int enet_protocol_handle_send_fragment(ENetHost host, ENetPeer peer, ENetProtocol command, const(ubyte)[] currentData, int[] currentDataI)
	{
		int fragmentNumber;
		int fragmentCount;
		int fragmentOffset;
		int fragmentLength;
		int startSequenceNumber;
		int totalLength;
		ENetChannel channel;
		ushort startWindow;
		ushort currentWindow;
		ENetListNode currentCommand;
		ENetIncomingCommand startCommand = null;
		if (command.header.channelID >= peer.channelCount || peer.state != 5 && peer.state != 6)
			return -1;
		fragmentLength = this.p.ENET_NET_TO_HOST_16(command.sendFragment.dataLength);
		currentDataI[0] += fragmentLength;
		if (fragmentLength > 1073741824 || currentDataI[0] < 0 || currentDataI[0] > host.receivedDataLength)
			return -1;
		channel = peer.channels[command.header.channelID];
		startSequenceNumber = this.p.ENET_NET_TO_HOST_16(command.sendFragment.startSequenceNumber);
		startWindow = this.p.IntToUshort(startSequenceNumber / 4096);
		currentWindow = this.p.IntToUshort(channel.incomingReliableSequenceNumber / 4096);
		if (startSequenceNumber < channel.incomingReliableSequenceNumber)
			startWindow += 16;
		if (startWindow < currentWindow || startWindow >= currentWindow + 8 - 1)
			return 0;
		fragmentNumber = this.p.ENET_NET_TO_HOST_32(command.sendFragment.fragmentNumber);
		fragmentCount = this.p.ENET_NET_TO_HOST_32(command.sendFragment.fragmentCount);
		fragmentOffset = this.p.ENET_NET_TO_HOST_32(command.sendFragment.fragmentOffset);
		totalLength = this.p.ENET_NET_TO_HOST_32(command.sendFragment.totalLength);
		if (fragmentCount > 1048576 || fragmentNumber >= fragmentCount || totalLength > 1073741824 || fragmentOffset >= totalLength || fragmentLength > totalLength - fragmentOffset)
			return -1;
		for (currentCommand = this.enet_list_previous(this.enet_list_end(channel.incomingReliableCommands)); currentCommand != this.enet_list_end(channel.incomingReliableCommands); currentCommand = this.enet_list_previous(currentCommand)) {
			ENetIncomingCommand incomingCommand = this.p.CastToENetIncomingCommand(currentCommand);
			if (startSequenceNumber >= channel.incomingReliableSequenceNumber) {
				if (incomingCommand.reliableSequenceNumber < channel.incomingReliableSequenceNumber)
					continue;
			}
			else if (incomingCommand.reliableSequenceNumber >= channel.incomingReliableSequenceNumber)
				break;
			if (incomingCommand.reliableSequenceNumber <= startSequenceNumber) {
				if (incomingCommand.reliableSequenceNumber < startSequenceNumber)
					break;
				if ((incomingCommand.command.header.command & 15) != 8 || totalLength != incomingCommand.packet.dataLength || fragmentCount != incomingCommand.fragmentCount)
					return -1;
				startCommand = incomingCommand;
				break;
			}
		}
		if (startCommand == null) {
			ENetProtocol hostCommand = command;
			ENetPacket packet = this.enet_packet_create(null, totalLength, 1);
			if (packet == null)
				return -1;
			hostCommand.header.reliableSequenceNumber = this.p.IntToUshort(startSequenceNumber);
			startCommand = this.enet_peer_queue_incoming_command(peer, hostCommand, packet, fragmentCount);
			if (startCommand == null)
				return -1;
		}
		if ((startCommand.fragments[fragmentNumber / 32] & 1 << fragmentNumber % 32) == 0) {
			startCommand.fragmentsRemaining--;
			startCommand.fragments[fragmentNumber / 32] |= 1 << fragmentNumber % 32;
			if (fragmentOffset + fragmentLength > startCommand.packet.dataLength)
				fragmentLength = startCommand.packet.dataLength - fragmentOffset;
			ubyte[] data = new ubyte[128];
			this.SerializeCommand(data, command);
			for (int i = 0; i < fragmentLength; i++) {
				startCommand.packet.data[i + fragmentOffset] = data[i + 28];
			}
			if (startCommand.fragmentsRemaining <= 0)
				this.enet_peer_dispatch_incoming_reliable_commands(peer, channel);
		}
		return 0;
	}

	private int enet_protocol_handle_send_reliable(ENetHost host, ENetPeer peer, ENetProtocol command, const(ubyte)[] currentData, int[] currentDataI)
	{
		ENetPacket packet;
		int dataLength;
		if (command.header.channelID >= peer.channelCount || peer.state != 5 && peer.state != 6)
			return -1;
		dataLength = this.ENET_NET_TO_HOST_16(command.sendReliable.dataLength);
		if (dataLength > 1073741824 || currentDataI[0] < 0 || currentDataI[0] > host.receivedDataLength)
			return -1;
		command.data = new ubyte[dataLength];
		for (int i = 0; i < dataLength; i++) {
			command.data[i] = currentData[currentDataI[0] + i];
		}
		currentDataI[0] += dataLength;
		packet = this.enet_packet_create(command.data, dataLength, 1);
		if (packet == null || this.enet_peer_queue_incoming_command(peer, command, packet, 0) == null)
			return -1;
		return 0;
	}

	final int enet_protocol_handle_send_unreliable(ENetHost host, ENetPeer peer, ENetProtocol command, const(ubyte)[] currentData, int[] currentDataI)
	{
		ENetPacket packet;
		int dataLength;
		if (command.header.channelID >= peer.channelCount || peer.state != 5 && peer.state != 6)
			return -1;
		dataLength = this.p.ENET_NET_TO_HOST_16(command.sendUnreliable.dataLength);
		currentDataI[0] += dataLength;
		if (dataLength > 1073741824 || currentDataI[0] < 0 || currentDataI[0] > host.receivedDataLength)
			return -1;
		command.data = new ubyte[dataLength];
		for (int i = 0; i < dataLength; i++) {
			command.data[i] = currentData[currentDataI[0] - dataLength + i];
		}
		packet = this.enet_packet_create(command.data, dataLength, 0);
		if (packet == null || this.enet_peer_queue_incoming_command(peer, command, packet, 0) == null)
			return -1;
		return 0;
	}

	final int enet_protocol_handle_send_unreliable_fragment(ENetHost host, ENetPeer peer, ENetProtocol command, const(ubyte)[] currentData)
	{
		int fragmentNumber;
		int fragmentCount;
		int fragmentOffset;
		int fragmentLength;
		int reliableSequenceNumber;
		int startSequenceNumber;
		int totalLength;
		ushort reliableWindow;
		ushort currentWindow;
		ENetChannel channel;
		ENetListNode currentCommand;
		ENetIncomingCommand startCommand = null;
		if (command.header.channelID >= peer.channelCount || peer.state != 5 && peer.state != 6)
			return -1;
		fragmentLength = this.ENET_NET_TO_HOST_16(command.sendFragment.dataLength);
		int currentDataI = 0;
		currentDataI += fragmentLength;
		if (fragmentLength > 1073741824 || currentDataI < 0 || currentDataI > host.receivedDataLength)
			return -1;
		channel = peer.channels[command.header.channelID];
		reliableSequenceNumber = command.header.reliableSequenceNumber;
		startSequenceNumber = this.ENET_NET_TO_HOST_16(command.sendFragment.startSequenceNumber);
		reliableWindow = this.p.IntToUshort(reliableSequenceNumber / 4096);
		currentWindow = this.p.IntToUshort(channel.incomingReliableSequenceNumber / 4096);
		if (reliableSequenceNumber < channel.incomingReliableSequenceNumber)
			reliableWindow += 16;
		if (reliableWindow < currentWindow || reliableWindow >= currentWindow + 8 - 1)
			return 0;
		if (reliableSequenceNumber == channel.incomingReliableSequenceNumber && startSequenceNumber <= channel.incomingUnreliableSequenceNumber)
			return 0;
		fragmentNumber = this.ENET_NET_TO_HOST_32(command.sendFragment.fragmentNumber);
		fragmentCount = this.ENET_NET_TO_HOST_32(command.sendFragment.fragmentCount);
		fragmentOffset = this.ENET_NET_TO_HOST_32(command.sendFragment.fragmentOffset);
		totalLength = this.ENET_NET_TO_HOST_32(command.sendFragment.totalLength);
		if (fragmentCount > 1048576 || fragmentNumber >= fragmentCount || totalLength > 1073741824 || fragmentOffset >= totalLength || fragmentLength > totalLength - fragmentOffset)
			return -1;
		for (currentCommand = this.enet_list_previous(this.enet_list_end(channel.incomingUnreliableCommands)); currentCommand != this.enet_list_end(channel.incomingUnreliableCommands); currentCommand = this.enet_list_previous(currentCommand)) {
			ENetIncomingCommand incomingCommand = this.p.CastToENetIncomingCommand(currentCommand);
			if (reliableSequenceNumber >= channel.incomingReliableSequenceNumber) {
				if (incomingCommand.reliableSequenceNumber < channel.incomingReliableSequenceNumber)
					continue;
			}
			else if (incomingCommand.reliableSequenceNumber >= channel.incomingReliableSequenceNumber)
				break;
			if (incomingCommand.reliableSequenceNumber < reliableSequenceNumber)
				break;
			if (incomingCommand.reliableSequenceNumber > reliableSequenceNumber)
				continue;
			if (incomingCommand.unreliableSequenceNumber <= startSequenceNumber) {
				if (incomingCommand.unreliableSequenceNumber < startSequenceNumber)
					break;
				if ((incomingCommand.command.header.command & 15) != 12 || totalLength != incomingCommand.packet.dataLength || fragmentCount != incomingCommand.fragmentCount)
					return -1;
				startCommand = incomingCommand;
				break;
			}
		}
		if (startCommand == null) {
			ENetPacket packet = this.enet_packet_create(null, totalLength, 8);
			if (packet == null)
				return -1;
			startCommand = this.enet_peer_queue_incoming_command(peer, command, packet, fragmentCount);
			if (startCommand == null)
				return -1;
		}
		if ((startCommand.fragments[fragmentNumber / 32] & 1 << fragmentNumber % 32) == 0) {
			startCommand.fragmentsRemaining--;
			startCommand.fragments[fragmentNumber / 32] |= 1 << fragmentNumber % 32;
			if (fragmentOffset + fragmentLength > startCommand.packet.dataLength)
				fragmentLength = startCommand.packet.dataLength - fragmentOffset;
			for (int i = 0; i < fragmentLength; i++) {
				startCommand.packet.data[fragmentOffset + i] = command.data[i];
			}
			if (startCommand.fragmentsRemaining <= 0)
				this.enet_peer_dispatch_incoming_unreliable_commands(peer, channel);
		}
		return 0;
	}

	final int enet_protocol_handle_send_unsequenced(ENetHost host, ENetPeer peer, ENetProtocol command, const(ubyte)[] currentData)
	{
		return 0;
	}

	final int enet_protocol_handle_throttle_configure(ENetHost host, ENetPeer peer, ENetProtocol command)
	{
		if (peer.state != 5 && peer.state != 6)
			return -1;
		peer.packetThrottleInterval = this.p.ENET_NET_TO_HOST_32(command.throttleConfigure.packetThrottleInterval);
		peer.packetThrottleAcceleration = this.p.ENET_NET_TO_HOST_32(command.throttleConfigure.packetThrottleAcceleration);
		peer.packetThrottleDeceleration = this.p.ENET_NET_TO_HOST_32(command.throttleConfigure.packetThrottleDeceleration);
		return 0;
	}

	final int enet_protocol_handle_verify_connect(ENetHost host, ENetEvent event_, ENetPeer peer, ENetProtocol command)
	{
		int mtu;
		int windowSize;
		int channelCount;
		if (peer.state != 1)
			return 0;
		channelCount = this.p.ENET_NET_TO_HOST_32(command.verifyConnect.channelCount);
		if (channelCount < 1 || channelCount > 255 || this.p.ENET_NET_TO_HOST_32(command.verifyConnect.packetThrottleInterval) != peer.packetThrottleInterval || this.p.ENET_NET_TO_HOST_32(command.verifyConnect.packetThrottleAcceleration) != peer.packetThrottleAcceleration || this.p.ENET_NET_TO_HOST_32(command.verifyConnect.packetThrottleDeceleration) != peer.packetThrottleDeceleration || command.verifyConnect.connectID != peer.connectID) {
			peer.eventData = 0;
			this.enet_protocol_dispatch_state(host, peer, 9);
			return -1;
		}
		this.enet_protocol_remove_sent_reliable_command(peer, 1, 255);
		if (channelCount < peer.channelCount)
			peer.channelCount = channelCount;
		peer.outgoingPeerID = this.p.ENET_NET_TO_HOST_16(command.verifyConnect.outgoingPeerID);
		peer.incomingSessionID = command.verifyConnect.incomingSessionID;
		peer.outgoingSessionID = command.verifyConnect.outgoingSessionID;
		mtu = this.p.ENET_NET_TO_HOST_32(command.verifyConnect.mtu);
		if (mtu < 576)
			mtu = 576;
		else if (mtu > 4096)
			mtu = 4096;
		if (mtu < peer.mtu)
			peer.mtu = mtu;
		windowSize = this.p.ENET_NET_TO_HOST_32(command.verifyConnect.windowSize);
		if (windowSize < 4096)
			windowSize = 4096;
		if (windowSize > 32768)
			windowSize = 32768;
		if (windowSize < peer.windowSize)
			peer.windowSize = windowSize;
		peer.incomingBandwidth = this.p.ENET_NET_TO_HOST_32(command.verifyConnect.incomingBandwidth);
		peer.outgoingBandwidth = this.p.ENET_NET_TO_HOST_32(command.verifyConnect.outgoingBandwidth);
		this.enet_protocol_notify_connect(host, peer, event_);
		return 0;
	}

	final void enet_protocol_notify_connect(ENetHost host, ENetPeer peer, ENetEvent event_)
	{
		host.recalculateBandwidthLimits = 1;
		if (event_ != null) {
			this.enet_protocol_change_state(host, peer, 5);
			event_.type = ENetEventType.ENET_EVENT_TYPE_CONNECT;
			event_.peer = peer;
			event_.data = peer.eventData;
		}
		else
			this.enet_protocol_dispatch_state(host, peer, peer.state == 1 ? 4 : 3);
	}

	final void enet_protocol_notify_disconnect(ENetHost host, ENetPeer peer, ENetEvent event_)
	{
		if (peer.state >= 3)
			host.recalculateBandwidthLimits = 1;
		if (peer.state != 1 && peer.state < 4)
			this.enet_peer_reset(peer);
		else if (event_ != null) {
			event_.type = ENetEventType.ENET_EVENT_TYPE_DISCONNECT;
			event_.peer = peer;
			event_.data = 0;
			this.enet_peer_reset(peer);
		}
		else {
			peer.eventData = 0;
			this.enet_protocol_dispatch_state(host, peer, 9);
		}
	}

	final int enet_protocol_receive_incoming_commands(ENetHost host, ENetEvent event_)
	{
		for (;;) {
			int receivedLength;
			ENetBuffer buffer = new ENetBuffer;
			buffer.data = host.packetData[0];
			buffer.dataLength = 4096;
			ENetBuffer[] buffers = new ENetBuffer[1];
			buffers[0] = buffer;
			receivedLength = this.p.enet_socket_receive(host.socket, host.receivedAddress, buffers, 1);
			if (receivedLength < 0)
				return -1;
			if (receivedLength == 0)
				return 0;
			host.receivedData = host.packetData[0];
			host.receivedDataLength = receivedLength;
			host.totalReceivedData += receivedLength;
			host.totalReceivedPackets++;
			if (host.intercept != null) {
				switch (host.intercept.Run(host, event_)) {
				case 1:
					if (event_ != null && event_.type != ENetEventType.ENET_EVENT_TYPE_NONE)
						return 1;
					continue;
				case -1:
					return -1;
				default:
					break;
				}
			}
			switch (this.enet_protocol_handle_incoming_commands(host, event_)) {
			case 1:
				return 1;
			case -1:
				return -1;
			default:
				break;
			}
		}
	}

	final int enet_protocol_remove_sent_reliable_command(ENetPeer peer, ushort reliableSequenceNumber, ubyte channelID)
	{
		ENetOutgoingCommand outgoingCommand = null;
		ENetListNode currentCommand;
		int commandNumber;
		int wasSent = 1;
		for (currentCommand = this.enet_list_begin(peer.sentReliableCommands); currentCommand != this.enet_list_end(peer.sentReliableCommands); currentCommand = this.enet_list_next(currentCommand)) {
			outgoingCommand = this.p.CastToENetOutgoingCommand(currentCommand);
			if (outgoingCommand.reliableSequenceNumber == reliableSequenceNumber && outgoingCommand.command.header.channelID == channelID)
				break;
		}
		if (currentCommand == this.enet_list_end(peer.sentReliableCommands)) {
			for (currentCommand = this.enet_list_begin(peer.outgoingReliableCommands); currentCommand != this.enet_list_end(peer.outgoingReliableCommands); currentCommand = this.enet_list_next(currentCommand)) {
				outgoingCommand = this.p.CastToENetOutgoingCommand(currentCommand);
				if (outgoingCommand.sendAttempts < 1)
					return 0;
				if (outgoingCommand.reliableSequenceNumber == reliableSequenceNumber && outgoingCommand.command.header.channelID == channelID)
					break;
			}
			if (currentCommand == this.enet_list_end(peer.outgoingReliableCommands))
				return 0;
			wasSent = 0;
		}
		if (outgoingCommand == null)
			return 0;
		if (channelID < peer.channelCount) {
			ENetChannel channel = peer.channels[channelID];
			ushort reliableWindow = this.p.IntToUshort(reliableSequenceNumber / 4096);
			if (channel.reliableWindows[reliableWindow] > 0) {
				channel.reliableWindows[reliableWindow]--;
				if (channel.reliableWindows[reliableWindow] == 0)
					channel.usedReliableWindows &= ~(1 << reliableWindow);
			}
		}
		commandNumber = outgoingCommand.command.header.command & 15;
		this.enet_list_remove(outgoingCommand.outgoingCommandList());
		if (outgoingCommand.packet != null) {
			if (wasSent != 0)
				peer.reliableDataInTransit -= outgoingCommand.fragmentLength;
			outgoingCommand.packet.referenceCount--;
			if (outgoingCommand.packet.referenceCount == 0) {
				outgoingCommand.packet.flags |= 256;
				this.enet_packet_destroy(outgoingCommand.packet);
			}
		}
		if (this.enet_list_empty(peer.sentReliableCommands))
			return commandNumber;
		outgoingCommand = this.p.CastToENetOutgoingCommand(this.enet_list_front(peer.sentReliableCommands));
		peer.nextTimeout = outgoingCommand.sentTime + outgoingCommand.roundTripTimeout;
		return commandNumber;
	}

	final void enet_protocol_remove_sent_unreliable_commands(ENetPeer peer)
	{
		ENetOutgoingCommand outgoingCommand;
		while (!this.enet_list_empty(peer.sentUnreliableCommands)) {
			outgoingCommand = this.p.CastToENetOutgoingCommand(this.enet_list_front(peer.sentUnreliableCommands));
			this.enet_list_remove(outgoingCommand.outgoingCommandList());
			if (outgoingCommand.packet != null) {
				outgoingCommand.packet.referenceCount--;
				if (outgoingCommand.packet.referenceCount == 0) {
					outgoingCommand.packet.flags |= 256;
					this.enet_packet_destroy(outgoingCommand.packet);
				}
			}
		}
	}

	private void enet_protocol_send_acknowledgements(ENetHost host, ENetPeer peer)
	{
		int commandI = host.commandCount;
		int bufferI = host.bufferCount;
		ENetAcknowledgement acknowledgement;
		ENetListNode currentAcknowledgement;
		ushort reliableSequenceNumber;
		currentAcknowledgement = this.enet_list_begin(peer.acknowledgements);
		while (currentAcknowledgement != this.enet_list_end(peer.acknowledgements)) {
			if (commandI >= 32 || bufferI >= 65 || peer.mtu - host.packetSize < 8) {
				host.continueSending = 1;
				break;
			}
			acknowledgement = this.p.CastToENetAcknowledgement(currentAcknowledgement);
			currentAcknowledgement = this.enet_list_next(currentAcknowledgement);
			if (this.test1 == 1) {
			}
			reliableSequenceNumber = this.ENET_HOST_TO_NET_16(acknowledgement.command.header.reliableSequenceNumber);
			host.commands[commandI].header.command = 1;
			host.commands[commandI].header.channelID = acknowledgement.command.header.channelID;
			host.commands[commandI].header.reliableSequenceNumber = reliableSequenceNumber;
			host.commands[commandI].acknowledge = new ENetProtocolAcknowledge;
			host.commands[commandI].acknowledge.receivedReliableSequenceNumber = reliableSequenceNumber;
			host.commands[commandI].acknowledge.receivedSentTime = this.ENET_HOST_TO_NET_16(this.p.IntToUshort(acknowledgement.sentTime));
			ubyte[] buf = new ubyte[128];
			this.SerializeCommand(buf, host.commands[commandI]);
			host.buffers[bufferI].data = buf;
			host.buffers[bufferI].dataLength = 8;
			host.packetSize += host.buffers[bufferI].dataLength;
			if ((acknowledgement.command.header.command & 15) == 4)
				this.enet_protocol_dispatch_state(host, peer, 9);
			this.enet_list_remove(acknowledgement.acknowledgementList());
			commandI++;
			bufferI++;
		}
		host.commandCount = commandI;
		host.bufferCount = bufferI;
	}

	final int enet_protocol_send_outgoing_commands(ENetHost host, ENetEvent event_, int checkForTimeouts)
	{
		ubyte[] headerData = new ubyte[8];
		ENetProtocolHeader header = new ENetProtocolHeader;
		ENetPeer currentPeer;
		int sentLength;
		int shouldCompress = 0;
		host.continueSending = 1;
		while (host.continueSending != 0) {
			host.continueSending = 0;
			for (int i = 0; i < host.peerCount; i++) {
				if (this.test1 == 1) {
				}
				currentPeer = host.peers[i];
				if (currentPeer.state == 0 || currentPeer.state == 9)
					continue;
				host.headerFlags = 0;
				host.commandCount = 0;
				host.bufferCount = 1;
				host.packetSize = 4;
				if (!this.enet_list_empty(currentPeer.acknowledgements))
					this.enet_protocol_send_acknowledgements(host, currentPeer);
				if (checkForTimeouts != 0 && !this.enet_list_empty(currentPeer.sentReliableCommands) && this.ENET_TIME_GREATER_EQUAL(host.serviceTime, currentPeer.nextTimeout) && this.enet_protocol_check_timeouts(host, currentPeer, event_) == 1) {
					if (event_ != null && event_.type != ENetEventType.ENET_EVENT_TYPE_NONE)
						return 1;
					else
						continue;
				}
				if ((this.enet_list_empty(currentPeer.outgoingReliableCommands) || this.enet_protocol_send_reliable_outgoing_commands(host, currentPeer) != 0) && this.enet_list_empty(currentPeer.sentReliableCommands) && this.ENET_TIME_DIFFERENCE(host.serviceTime, currentPeer.lastReceiveTime) >= currentPeer.pingInterval && currentPeer.mtu - host.packetSize >= 4) {
					this.enet_peer_ping(currentPeer);
					this.enet_protocol_send_reliable_outgoing_commands(host, currentPeer);
				}
				if (!this.enet_list_empty(currentPeer.outgoingUnreliableCommands))
					this.enet_protocol_send_unreliable_outgoing_commands(host, currentPeer);
				if (host.commandCount == 0)
					continue;
				if (currentPeer.packetLossEpoch == 0)
					currentPeer.packetLossEpoch = host.serviceTime;
				else if (this.ENET_TIME_DIFFERENCE(host.serviceTime, currentPeer.packetLossEpoch) >= 10000 && currentPeer.packetsSent > 0) {
					int packetLoss = currentPeer.packetsLost * 65536 / currentPeer.packetsSent;
					currentPeer.packetLossVariance -= currentPeer.packetLossVariance / 4;
					if (packetLoss >= currentPeer.packetLoss) {
						currentPeer.packetLoss += (packetLoss - currentPeer.packetLoss) / 8;
						currentPeer.packetLossVariance += (packetLoss - currentPeer.packetLoss) / 4;
					}
					else {
						currentPeer.packetLoss -= (currentPeer.packetLoss - packetLoss) / 8;
						currentPeer.packetLossVariance += (currentPeer.packetLoss - packetLoss) / 4;
					}
					currentPeer.packetLossEpoch = host.serviceTime;
					currentPeer.packetsSent = 0;
					currentPeer.packetsLost = 0;
				}
				host.buffers[0].data = headerData;
				if ((host.headerFlags & 32768) != 0) {
					header.sentTime = this.ENET_HOST_TO_NET_16(this.p.IntToUshort(host.serviceTime & 65535));
					host.buffers[0].dataLength = 4;
				}
				else {
					host.buffers[0].dataLength = 2;
				}
				shouldCompress = 0;
				if (host.compressor != null) {
				}
				if (currentPeer.outgoingPeerID < 4095)
					host.headerFlags |= this.p.IntToUshort(currentPeer.outgoingSessionID << 12);
				header.peerID = this.ENET_HOST_TO_NET_16(this.p.IntToUshort(currentPeer.outgoingPeerID | host.headerFlags));
				this.SerializeHeader(headerData, header);
				if (host.checksum != null) {
				}
				if (shouldCompress > 0) {
					host.buffers[1].data = host.packetData[1];
					host.buffers[1].dataLength = shouldCompress;
					host.bufferCount = 2;
				}
				currentPeer.lastSendTime = host.serviceTime;
				sentLength = this.p.enet_socket_send(host.socket, currentPeer.address, host.buffers, host.bufferCount);
				this.enet_protocol_remove_sent_unreliable_commands(currentPeer);
				if (sentLength < 0)
					return -1;
				host.totalSentData += sentLength;
				host.totalSentPackets++;
			}
		}
		return 0;
	}

	final int enet_protocol_send_reliable_outgoing_commands(ENetHost host, ENetPeer peer)
	{
		int commandI = host.commandCount;
		int bufferI = host.bufferCount;
		ENetOutgoingCommand outgoingCommand;
		ENetListNode currentCommand;
		ENetChannel channel;
		ushort reliableWindow;
		int commandSize;
		int windowExceeded = 0;
		int windowWrap = 0;
		int canPing = 1;
		currentCommand = this.enet_list_begin(peer.outgoingReliableCommands);
		if (this.test1 == 1) {
			this.test1 = this.test1;
		}
		while (currentCommand != this.enet_list_end(peer.outgoingReliableCommands)) {
			outgoingCommand = this.p.CastToENetOutgoingCommand(currentCommand);
			channel = outgoingCommand.command.header.channelID < peer.channelCount ? peer.channels[outgoingCommand.command.header.channelID] : null;
			reliableWindow = this.p.IntToUshort(outgoingCommand.reliableSequenceNumber / 4096);
			if (channel != null) {
				if (windowWrap == 0 && outgoingCommand.sendAttempts < 1 && outgoingCommand.reliableSequenceNumber % 4096 == 0 && (channel.reliableWindows[(reliableWindow + 16 - 1) % 16] >= 4096 || (channel.usedReliableWindows & (255 << reliableWindow | 255 >> 4096 - reliableWindow)) != 0))
					windowWrap = 1;
				if (windowWrap != 0) {
					currentCommand = this.enet_list_next(currentCommand);
					continue;
				}
			}
			if (outgoingCommand.packet != null) {
				if (windowExceeded == 0) {
					int windowSize = peer.packetThrottle * peer.windowSize / 32;
					if (peer.reliableDataInTransit + outgoingCommand.fragmentLength > this.ENET_MAX(windowSize, peer.mtu))
						windowExceeded = 1;
				}
				if (windowExceeded != 0) {
					currentCommand = this.enet_list_next(currentCommand);
					continue;
				}
			}
			canPing = 0;
			commandSize = this.commandSizes[outgoingCommand.command.header.command & 15];
			if (commandI > host.commandCount || bufferI > host.bufferCount || peer.mtu - host.packetSize < commandSize || outgoingCommand.packet != null && this.ToUint16(peer.mtu - host.packetSize) < this.ToUint16(commandSize + outgoingCommand.fragmentLength)) {
				host.continueSending = 1;
				break;
			}
			currentCommand = this.enet_list_next(currentCommand);
			if (channel != null && outgoingCommand.sendAttempts < 1) {
				channel.usedReliableWindows |= 1 << reliableWindow;
				channel.reliableWindows[reliableWindow]++;
			}
			outgoingCommand.sendAttempts++;
			if (outgoingCommand.roundTripTimeout == 0) {
				outgoingCommand.roundTripTimeout = peer.roundTripTime + 4 * peer.roundTripTimeVariance;
				outgoingCommand.roundTripTimeoutLimit = peer.timeoutLimit * outgoingCommand.roundTripTimeout;
			}
			if (this.enet_list_empty(peer.sentReliableCommands))
				peer.nextTimeout = host.serviceTime + outgoingCommand.roundTripTimeout;
			this.enet_list_insert(this.enet_list_end(peer.sentReliableCommands), this.enet_list_remove(outgoingCommand.outgoingCommandList()));
			outgoingCommand.sentTime = host.serviceTime;
			ENetProtocol command = outgoingCommand.command;
			host.commands[commandI] = command;
			host.buffers[bufferI].data = new ubyte[commandSize];
			this.SerializeCommand(host.buffers[bufferI].data, host.commands[commandI]);
			host.buffers[bufferI].dataLength = commandSize;
			host.packetSize += host.buffers[bufferI].dataLength;
			host.headerFlags |= 32768;
			if (outgoingCommand.packet != null) {
				bufferI++;
				ubyte[] data = new ubyte[outgoingCommand.packet.dataLength];
				for (int i = 0; i < outgoingCommand.packet.dataLength - outgoingCommand.fragmentOffset; i++) {
					data[i] = outgoingCommand.packet.data[i + outgoingCommand.fragmentOffset];
				}
				host.buffers[bufferI].data = data;
				host.buffers[bufferI].dataLength = outgoingCommand.fragmentLength;
				host.packetSize += outgoingCommand.fragmentLength;
				peer.reliableDataInTransit += outgoingCommand.fragmentLength;
			}
			peer.packetsSent++;
			commandI++;
			bufferI++;
		}
		host.commandCount = commandI;
		host.bufferCount = bufferI;
		return canPing;
	}

	final void enet_protocol_send_unreliable_outgoing_commands(ENetHost host, ENetPeer peer)
	{
	}

	private ENetIncomingCommand freePacket(int fragmentCount, ENetPacket packet)
	{
		if (fragmentCount > 0)
			return this.notifyError(packet);
		if (packet != null && packet.referenceCount == 0)
			this.enet_packet_destroy(packet);
		return this.dummyCommand;
	}

	private void initialize_crc32()
	{
		this.crcTable = new int[256];
		int byte_;
		int c = -2147483647;
		c -= 1;
		for (byte_ = 0; byte_ < 256; byte_++) {
			int crc = ENet.reflect_crc(byte_, 8) << 24;
			int offset;
			for (offset = 0; offset < 8; offset++) {
				if ((crc & c) != 0)
					crc = crc << 1 ^ 79764919;
				else
					crc <<= 1;
			}
			this.crcTable[byte_] = ENet.reflect_crc(crc, 32);
		}
		this.initializedCRC32 = true;
	}
	private bool initializedCRC32;

	private void memcpy(ubyte[] destination, const(ubyte)[] source, int num)
	{
		for (int i = 0; i < num; i++) {
			destination[i] = source[i];
		}
	}

	private ENetIncomingCommand notifyError(ENetPacket packet)
	{
		if (packet != null && packet.referenceCount == 0)
			this.enet_packet_destroy(packet);
		return null;
	}
	private ENetPlatform p;

	private static int reflect_crc(int val, int bits)
	{
		int result = 0;
		int bit;
		for (bit = 0; bit < bits; bit++) {
			if ((val & 1) != 0)
				result |= 1 << bits - 1 - bit;
			val >>= 1;
		}
		return result;
	}
	private int test1;
	this()
	{
		this.dummyCommand = new ENetIncomingCommand;
		this.commandSizes = new int[13];
		this.commandSizes[0] = 0;
		this.commandSizes[1] = 8;
		this.commandSizes[2] = 48;
		this.commandSizes[3] = 44;
		this.commandSizes[4] = 8;
		this.commandSizes[5] = 4;
		this.commandSizes[6] = 6;
		this.commandSizes[7] = 8;
		this.commandSizes[8] = 24;
		this.commandSizes[9] = 8;
		this.commandSizes[10] = 12;
		this.commandSizes[11] = 16;
		this.commandSizes[12] = 24;
	}
}

class ENetAcknowledgement : ENetListNode
{

	final ENetListNode acknowledgementList()
	{
		return this;
	}
	ENetProtocol command;
	int sentTime;
}

class ENetAddress
{

	static ENetAddress Clone(ENetAddress address)
	{
		ENetAddress other = new ENetAddress;
		other.host = address.host;
		other.port = address.port;
		return other;
	}
	int host;
	int port;
}

class ENetBuffer
{
	ubyte[] data;
	int dataLength;
}

class ENetChannel
{
	ENetList incomingReliableCommands;
	int incomingReliableSequenceNumber;
	ENetList incomingUnreliableCommands;
	int incomingUnreliableSequenceNumber;
	ushort outgoingReliableSequenceNumber;
	ushort outgoingUnreliableSequenceNumber;
	int[] reliableWindows;
	public static immutable(int) reliableWindowsLength = 16;
	int usedReliableWindows;
	this()
	{
		this.reliableWindows = new int[16];
		this.incomingReliableCommands = new ENetList;
		this.incomingUnreliableCommands = new ENetList;
	}
}

abstract class ENetChecksumCallback
{

	abstract int Run(ENetBuffer buffers, int bufferCount);
}

/// An ENet packet compressor for compressing UDP packets before socket sends or receives.
abstract class ENetCompressor
{

	/// Compresses from inBuffers[0:inBufferCount-1], containing inLimit bytes, to outData, outputting at most outLimit bytes. Should return 0 on failure.
	abstract int compress(ENetBuffer inBuffers, int inBufferCount, int inLimit, const(ubyte)[] outData, int outLimit);

	/// Decompresses from inData, containing inLimit bytes, to outData, outputting at most outLimit bytes. Should return 0 on failure.
	abstract int decompress(const(ubyte)[] inData, int inLimit, const(ubyte)[] outData, int outLimit);

	/// Destroys the context when compression is disabled or the host is destroyed. May be NULL.
	abstract void destroy();
}

abstract class ENetCompressorContext
{
}

class ENetEvent
{
	ubyte channelID;
	int data;
	ENetPacket packet;
	ENetPeer peer;
	ENetEventType type;
}

enum ENetEventType
{
	ENET_EVENT_TYPE_NONE,
	ENET_EVENT_TYPE_CONNECT,
	ENET_EVENT_TYPE_DISCONNECT,
	ENET_EVENT_TYPE_RECEIVE
}

class ENetHost
{
	ENetAddress address;
	int bandwidthLimitedPeers;
	int bandwidthThrottleEpoch;
	int bufferCount;
	ENetBuffer[] buffers;
	public static immutable(int) buffersMaxCount = 65;
	int channelLimit;
	ENetChecksumCallback checksum;
	int commandCount;
	ENetProtocol[] commands;
	public static immutable(int) commandsMaxCount = 32;
	ENetCompressor compressor;
	int connectedPeers;
	int continueSending;
	ENetList dispatchQueue;
	ushort headerFlags;
	int incomingBandwidth;
	ENetInterceptCallback intercept;
	int mtu;
	int outgoingBandwidth;
	ubyte[][] packetData;
	public static immutable(int) packetData0SizeOf = 4096;
	int packetSize;
	int peerCount;
	ENetPeer[] peers;
	int randomSeed;
	int recalculateBandwidthLimits;
	ENetAddress receivedAddress;
	ubyte[] receivedData;
	int receivedDataLength;
	int serviceTime;
	ENetSocket socket;
	int totalReceivedData;
	int totalReceivedPackets;
	int totalSentData;
	int totalSentPackets;
	this()
	{
		this.address = new ENetAddress;
		this.commands = new ENetProtocol[32];
		for (int i = 0; i < 32; i++) {
			this.commands[i] = new ENetProtocol;
		}
		this.buffers = new ENetBuffer[65];
		for (int i = 0; i < 65; i++) {
			this.buffers[i] = new ENetBuffer;
		}
		for (int i = 0; i < 65; i++) {
			this.buffers[i] = new ENetBuffer;
		}
		this.dispatchQueue = new ENetPeer;
		this.packetData = new ubyte[2][];
		this.packetData[0] = new ubyte[4096];
		this.packetData[1] = new ubyte[4096];
	}
}

class ENetIncomingCommand : ENetListNode
{
	ENetProtocol command;
	int fragmentCount;
	int[] fragments;
	int fragmentsRemaining;

	final ENetListNode incomingCommandList()
	{
		return this;
	}
	ENetPacket packet;
	ushort reliableSequenceNumber;
	ushort unreliableSequenceNumber;
}

abstract class ENetInterceptCallback
{

	abstract int Run(ENetHost host, ENetEvent event_);
}

class ENetList : ENetListNode
{

	final ENetObject GetSentinel()
	{
		return this.next;
	}

	final void SetSentinel(ENetObject value)
	{
		this.next = value;
	}
	this()
	{
		this.SetSentinel(new ENetListNode);
	}
}

class ENetListNode : ENetObject
{
	ENetObject data;
	ENetObject next;
	ENetObject previous;
}

class ENetObject
{
}

class ENetOutgoingCommand : ENetListNode
{
	ENetProtocol command;
	ushort fragmentLength;
	int fragmentOffset;

	final ENetListNode outgoingCommandList()
	{
		return this;
	}
	ENetPacket packet;
	ushort reliableSequenceNumber;
	int roundTripTimeout;
	int roundTripTimeoutLimit;
	ushort sendAttempts;
	int sentTime;
	ushort unreliableSequenceNumber;
}

class ENetPacket
{

	final const(ubyte)[] GetData()
	{
		return this.data;
	}

	final int GetDataLength()
	{
		return this.dataLength;
	}

	final int GetFlags()
	{
		return this.flags;
	}

	final ENetPacketFreeCallback GetFreeCallback()
	{
		return this.freeCallback;
	}

	final int GetReferenceCount()
	{
		return this.referenceCount;
	}

	final UserData GetUserData()
	{
		return this.userData;
	}

	final void SetData(ubyte[] value)
	{
		this.data = value;
	}

	final void SetDataLength(int value)
	{
		this.dataLength = value;
	}

	final void SetFlags(int value)
	{
		this.flags = value;
	}

	final void SetFreeCallback(ENetPacketFreeCallback value)
	{
		this.freeCallback = value;
	}

	final void SetReferenceCount(int value)
	{
		this.referenceCount = value;
	}

	final void SetUserData(UserData value)
	{
		this.userData = value;
	}
	ubyte[] data;
	int dataLength;
	/// &lt; internal use only
	int flags;
	ENetPacketFreeCallback freeCallback;
	int referenceCount;
	UserData userData;
}

class ENetPacketFlagEnum
{
	public static immutable(int) ENET_PACKET_FLAG_NO_ALLOCATE = 4;
	public static immutable(int) ENET_PACKET_FLAG_RELIABLE = 1;
	public static immutable(int) ENET_PACKET_FLAG_SENT = 256;
	public static immutable(int) ENET_PACKET_FLAG_UNRELIABLE_FRAGMENT = 8;
	public static immutable(int) ENET_PACKET_FLAG_UNSEQUENCED = 2;
}

abstract class ENetPacketFreeCallback
{

	abstract void Run(ENetPacket packet);
}

class ENetPeer : ENetList
{
	ENetList acknowledgements;
	ENetAddress address;
	int channelCount;
	ENetChannel[] channels;
	int connectID;
	const(ubyte)[] data;

	final ENetListNode dispatchList()
	{
		return this;
	}
	ENetList dispatchedCommands;
	int earliestTimeout;
	int eventData;
	int highestRoundTripTimeVariance;
	ENetHost host;
	int incomingBandwidth;
	int incomingBandwidthThrottleEpoch;
	int incomingDataTotal;
	ushort incomingPeerID;
	ubyte incomingSessionID;
	int incomingUnsequencedGroup;
	int lastReceiveTime;
	int lastRoundTripTime;
	int lastRoundTripTimeVariance;
	int lastSendTime;
	int lowestRoundTripTime;
	int mtu;
	int needsDispatch;
	int nextTimeout;
	int outgoingBandwidth;
	int outgoingBandwidthThrottleEpoch;
	int outgoingDataTotal;
	ushort outgoingPeerID;
	ENetList outgoingReliableCommands;
	ushort outgoingReliableSequenceNumber;
	ubyte outgoingSessionID;
	ENetList outgoingUnreliableCommands;
	ushort outgoingUnsequencedGroup;
	int packetLoss;
	int packetLossEpoch;
	int packetLossVariance;
	int packetThrottle;
	int packetThrottleAcceleration;
	int packetThrottleCounter;
	int packetThrottleDeceleration;
	int packetThrottleEpoch;
	int packetThrottleInterval;
	int packetThrottleLimit;
	int packetsLost;
	int packetsSent;
	int pingInterval;
	int reliableDataInTransit;
	int roundTripTime;
	int roundTripTimeVariance;
	ENetList sentReliableCommands;
	ENetList sentUnreliableCommands;
	int state;
	int timeoutLimit;
	int timeoutMaximum;
	int timeoutMinimum;
	int[] unsequencedWindow;
	public static immutable(int) unsequencedWindowLength = 32;
	int windowSize;
	this()
	{
		this.acknowledgements = new ENetList;
		this.sentReliableCommands = new ENetList;
		this.sentUnreliableCommands = new ENetList;
		this.outgoingReliableCommands = new ENetList;
		this.outgoingUnreliableCommands = new ENetList;
		this.dispatchedCommands = new ENetList;
		this.unsequencedWindow = new int[32];
	}
}

class ENetPeerState
{
	public static immutable(int) ENET_PEER_STATE_ACKNOWLEDGING_CONNECT = 2;
	public static immutable(int) ENET_PEER_STATE_ACKNOWLEDGING_DISCONNECT = 8;
	public static immutable(int) ENET_PEER_STATE_CONNECTED = 5;
	public static immutable(int) ENET_PEER_STATE_CONNECTING = 1;
	public static immutable(int) ENET_PEER_STATE_CONNECTION_PENDING = 3;
	public static immutable(int) ENET_PEER_STATE_CONNECTION_SUCCEEDED = 4;
	public static immutable(int) ENET_PEER_STATE_DISCONNECTED = 0;
	public static immutable(int) ENET_PEER_STATE_DISCONNECTING = 7;
	public static immutable(int) ENET_PEER_STATE_DISCONNECT_LATER = 6;
	public static immutable(int) ENET_PEER_STATE_ZOMBIE = 9;
}

abstract class ENetPlatform
{

	abstract ENetAcknowledgement CastToENetAcknowledgement(ENetListNode a);

	abstract ENetIncomingCommand CastToENetIncomingCommand(ENetObject a);

	abstract ENetListNode CastToENetListNode(ENetObject a);

	abstract ENetOutgoingCommand CastToENetOutgoingCommand(ENetObject a);

	abstract ENetPeer CastToENetPeer(ENetListNode a);

	abstract ushort ENET_HOST_TO_NET_16(ushort p);

	abstract int ENET_HOST_TO_NET_32(int p);

	abstract ushort ENET_NET_TO_HOST_16(ushort p);

	abstract int ENET_NET_TO_HOST_32(int fragmentOffset);

	abstract ushort IntToUshort(int p);

	abstract int enet_address_set_host(ENetAddress address, string hostName);

	abstract int enet_socket_accept(ENetSocket socket, ENetAddress address);

	abstract int enet_socket_bind(ENetSocket socket, ENetAddress address);

	abstract int enet_socket_connect(ENetSocket socket, ENetAddress address);

	abstract ENetSocket enet_socket_create(int type);

	abstract void enet_socket_destroy(ENetSocket socket);

	abstract int enet_socket_get_address(ENetSocket socket, ENetAddress address);

	abstract int enet_socket_listen(ENetSocket socket, int backlog);

	abstract int enet_socket_receive(ENetSocket socket, ENetAddress address, const(ENetBuffer)[] buffers, int bufferCount);

	abstract int enet_socket_send(ENetSocket socket, ENetAddress address, const(ENetBuffer)[] buffers, int bufferCount);

	abstract int enet_socket_set_option(ENetSocket socket, int option, int value);

	abstract int enet_socket_shutdown(ENetSocket socket, ENetSocketShutdown how);

	abstract int enet_socket_wait(ENetSocket socket, const(int)[] condition, int timeout);

	abstract int enet_time_get();

	abstract int time();
}

class ENetProtocol
{
	ENetProtocolAcknowledge acknowledge;
	ENetProtocolBandwidthLimit bandwidthLimit;
	ENetProtocolConnect connect;
	ubyte[] data;
	ENetProtocolDisconnect disconnect;
	ENetProtocolCommandHeader header;
	ENetProtocolPing ping;
	ENetProtocolSendFragment sendFragment;
	ENetProtocolSendReliable sendReliable;
	ENetProtocolSendUnreliable sendUnreliable;
	ENetProtocolSendUnsequenced sendUnsequenced;
	ENetProtocolThrottleConfigure throttleConfigure;
	ENetProtocolVerifyConnect verifyConnect;
	this()
	{
		this.header = new ENetProtocolCommandHeader;
	}
}

class ENetProtocolAcknowledge
{
	public static immutable(int) SizeOf = 8;
	ushort receivedReliableSequenceNumber;
	ushort receivedSentTime;
}

class ENetProtocolBandwidthLimit
{
	int incomingBandwidth;
	int outgoingBandwidth;
}

class ENetProtocolCommandHeader
{
	public static immutable(int) SizeOf = 4;
	ubyte channelID;
	ubyte command;
	ushort reliableSequenceNumber;
}

class ENetProtocolConnect
{
	int channelCount;
	int connectID;
	int data;
	int incomingBandwidth;
	ubyte incomingSessionID;
	int mtu;
	int outgoingBandwidth;
	ushort outgoingPeerID;
	ubyte outgoingSessionID;
	int packetThrottleAcceleration;
	int packetThrottleDeceleration;
	int packetThrottleInterval;
	int windowSize;
}

class ENetProtocolDisconnect
{
	int data;
}

class ENetProtocolHeader
{
	public static immutable(int) SizeOf = 4;
	ushort peerID;
	ushort sentTime;
}

class ENetProtocolPing
{
	public static immutable(int) SizeOf = 4;
}

class ENetProtocolSendFragment
{
	public static immutable(int) SizeOf = 28;
	ushort dataLength;
	int fragmentCount;
	int fragmentNumber;
	int fragmentOffset;
	ushort startSequenceNumber;
	int totalLength;
}

class ENetProtocolSendReliable
{
	public static immutable(int) SizeOf = 6;
	ushort dataLength;
}

class ENetProtocolSendUnreliable
{
	public static immutable(int) SizeOf = 12;
	ushort dataLength;
	ushort unreliableSequenceNumber;
}

class ENetProtocolSendUnsequenced
{
	ushort dataLength;
	ushort unsequencedGroup;
}

class ENetProtocolThrottleConfigure
{
	int packetThrottleAcceleration;
	int packetThrottleDeceleration;
	int packetThrottleInterval;
}

class ENetProtocolVerifyConnect
{
	int channelCount;
	int connectID;
	int incomingBandwidth;
	ubyte incomingSessionID;
	int mtu;
	int outgoingBandwidth;
	ushort outgoingPeerID;
	ubyte outgoingSessionID;
	int packetThrottleAcceleration;
	int packetThrottleDeceleration;
	int packetThrottleInterval;
	int windowSize;
}

abstract class ENetSocket
{

	abstract bool NULL();
}

class ENetSocketOption
{
	public static immutable(int) ENET_SOCKOPT_BROADCAST = 2;
	public static immutable(int) ENET_SOCKOPT_ERROR = 8;
	public static immutable(int) ENET_SOCKOPT_NODELAY = 9;
	public static immutable(int) ENET_SOCKOPT_NONBLOCK = 1;
	public static immutable(int) ENET_SOCKOPT_RCVBUF = 3;
	public static immutable(int) ENET_SOCKOPT_RCVTIMEO = 6;
	public static immutable(int) ENET_SOCKOPT_REUSEADDR = 5;
	public static immutable(int) ENET_SOCKOPT_SNDBUF = 4;
	public static immutable(int) ENET_SOCKOPT_SNDTIMEO = 7;
}

class ENetSocketShutdown
{
	public static immutable(int) ENET_SOCKET_SHUTDOWN_READ = 0;
	public static immutable(int) ENET_SOCKET_SHUTDOWN_READ_WRITE = 2;
	public static immutable(int) ENET_SOCKET_SHUTDOWN_WRITE = 1;
}

class ENetSocketTypeEnum
{
	public static immutable(int) ENET_SOCKET_TYPE_DATAGRAM = 2;
	public static immutable(int) ENET_SOCKET_TYPE_STREAM = 1;
}

class ENetSymbol
{
	private ubyte count;
	private int escapes;
	private int left;
	private int parent;
	private int right;
	private int symbols;
	private int total;
	private int under;
	private ubyte value;
}

class Math
{

	static bool isLessThanUnsigned(int n1, int n2)
	{
		bool comp = n1 < n2;
		if (n1 < 0 != n2 < 0) {
			comp = !comp;
		}
		return comp;
	}
}

abstract class UserData
{
}
