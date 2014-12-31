// Generated automatically with "cito". Do not edit.
package
{
	import flash.utils.ByteArray;

	public class ENetHost
	{
		public function ENetHost()
		{
			this.address = new ENetAddress();
			this.commands = new Array(32);
			for (var i : int = 0; i < 32; i++) {
				this.commands[i] = new ENetProtocol();
			}
			this.buffers = new Array(65);
			for (var i : int = 0; i < 65; i++) {
				this.buffers[i] = new ENetBuffer();
			}
			for (var i : int = 0; i < 65; i++) {
				this.buffers[i] = new ENetBuffer();
			}
			this.dispatchQueue = new ENetPeer();
			this.packetData = new Array(2);
			this.packetData[0] = new ByteArray();
			this.packetData[1] = new ByteArray();
		}
		/** @private */
		internal var address : ENetAddress;
		/** @private */
		internal var bandwidthLimitedPeers : int;
		/** @private */
		internal var bandwidthThrottleEpoch : int;
		/** @private */
		internal var bufferCount : int;
		/** @private */
		internal var buffers : Array;
		public static const BUFFERS_MAX_COUNT : int = 65;
		/** @private */
		internal var channelLimit : int;
		/** @private */
		internal var checksum : ENetChecksumCallback;
		/** @private */
		internal var commandCount : int;
		/** @private */
		internal var commands : Array;
		public static const COMMANDS_MAX_COUNT : int = 32;
		/** @private */
		internal var compressor : ENetCompressor;
		/** @private */
		internal var connectedPeers : int;
		/** @private */
		internal var continueSending : int;
		/** @private */
		internal var dispatchQueue : ENetList;
		/** @private */
		internal var headerFlags : int;
		/** @private */
		internal var incomingBandwidth : int;
		/** @private */
		internal var intercept : ENetInterceptCallback;
		/** @private */
		internal var mtu : int;
		/** @private */
		internal var outgoingBandwidth : int;
		/** @private */
		internal var packetData : Array;
		public static const PACKET_DATA0_SIZE_OF : int = 4096;
		/** @private */
		internal var packetSize : int;
		/** @private */
		internal var peerCount : int;
		/** @private */
		internal var peers : Array;
		/** @private */
		internal var randomSeed : int;
		/** @private */
		internal var recalculateBandwidthLimits : int;
		/** @private */
		internal var receivedAddress : ENetAddress;
		/** @private */
		internal var receivedData : ByteArray;
		/** @private */
		internal var receivedDataLength : int;
		/** @private */
		internal var serviceTime : int;
		/** @private */
		internal var socket : ENetSocket;
		/** @private */
		internal var totalReceivedData : int;
		/** @private */
		internal var totalReceivedPackets : int;
		/** @private */
		internal var totalSentData : int;
		/** @private */
		internal var totalSentPackets : int;
	}
}
