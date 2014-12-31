// Generated automatically with "cito". Do not edit.
package enetcito.lib;

public class ENetHost
{
	public ENetHost()
	{
		this.address = new ENetAddress();
		this.commands = new ENetProtocol[32];
		for (int i = 0; i < 32; i++) {
			this.commands[i] = new ENetProtocol();
		}
		this.buffers = new ENetBuffer[65];
		for (int i = 0; i < 65; i++) {
			this.buffers[i] = new ENetBuffer();
		}
		for (int i = 0; i < 65; i++) {
			this.buffers[i] = new ENetBuffer();
		}
		this.dispatchQueue = new ENetPeer();
		this.packetData = new byte[2][];
		this.packetData[0] = new byte[4096];
		this.packetData[1] = new byte[4096];
	}
	ENetAddress address;
	int bandwidthLimitedPeers;
	int bandwidthThrottleEpoch;
	int bufferCount;
	ENetBuffer[] buffers;
	public static final int BUFFERS_MAX_COUNT = 65;
	int channelLimit;
	ENetChecksumCallback checksum;
	int commandCount;
	ENetProtocol[] commands;
	public static final int COMMANDS_MAX_COUNT = 32;
	ENetCompressor compressor;
	int connectedPeers;
	int continueSending;
	ENetList dispatchQueue;
	int headerFlags;
	int incomingBandwidth;
	ENetInterceptCallback intercept;
	int mtu;
	int outgoingBandwidth;
	byte[][] packetData;
	public static final int PACKET_DATA0_SIZE_OF = 4096;
	int packetSize;
	int peerCount;
	ENetPeer[] peers;
	int randomSeed;
	int recalculateBandwidthLimits;
	ENetAddress receivedAddress;
	byte[] receivedData;
	int receivedDataLength;
	int serviceTime;
	ENetSocket socket;
	int totalReceivedData;
	int totalReceivedPackets;
	int totalSentData;
	int totalSentPackets;
}
