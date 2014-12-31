// Generated automatically with "cito". Do not edit.
package
{
	import flash.utils.ByteArray;

	public class ENetPeer extends ENetList
	{
		public function ENetPeer()
		{
			this.acknowledgements = new ENetList();
			this.sentReliableCommands = new ENetList();
			this.sentUnreliableCommands = new ENetList();
			this.outgoingReliableCommands = new ENetList();
			this.outgoingUnreliableCommands = new ENetList();
			this.dispatchedCommands = new ENetList();
			this.unsequencedWindow = new Array(32);
		}

		public final function getOutgoingReliableSequenceNumber() : int
		{
			return this.outgoingReliableSequenceNumber;
		}

		public final function setOutgoingReliableSequenceNumber(value : int) : void
		{
			this.outgoingReliableSequenceNumber = value % 65536;
		}
		/** @private */
		internal var acknowledgements : ENetList;
		/** @private */
		internal var address : ENetAddress;
		/** @private */
		internal var channelCount : int;
		/** @private */
		internal var channels : Array;
		/** @private */
		internal var connectID : int;
		/** @private */
		internal var data : ByteArray;

		/** @private */
		internal final function dispatchList() : ENetListNode
		{
			return this;
		}
		/** @private */
		internal var dispatchedCommands : ENetList;
		/** @private */
		internal var earliestTimeout : int;
		/** @private */
		internal var eventData : int;
		/** @private */
		internal var highestRoundTripTimeVariance : int;
		/** @private */
		internal var host : ENetHost;
		/** @private */
		internal var incomingBandwidth : int;
		/** @private */
		internal var incomingBandwidthThrottleEpoch : int;
		/** @private */
		internal var incomingDataTotal : int;
		/** @private */
		internal var incomingPeerID : int;
		/** @private */
		internal var incomingSessionID : int;
		/** @private */
		internal var incomingUnsequencedGroup : int;
		/** @private */
		internal var lastReceiveTime : int;
		/** @private */
		internal var lastRoundTripTime : int;
		/** @private */
		internal var lastRoundTripTimeVariance : int;
		/** @private */
		internal var lastSendTime : int;
		/** @private */
		internal var lowestRoundTripTime : int;
		/** @private */
		internal var mtu : int;
		/** @private */
		internal var needsDispatch : int;
		/** @private */
		internal var nextTimeout : int;
		/** @private */
		internal var outgoingBandwidth : int;
		/** @private */
		internal var outgoingBandwidthThrottleEpoch : int;
		/** @private */
		internal var outgoingDataTotal : int;
		/** @private */
		internal var outgoingPeerID : int;
		/** @private */
		internal var outgoingReliableCommands : ENetList;
		private var outgoingReliableSequenceNumber : int;
		/** @private */
		internal var outgoingSessionID : int;
		/** @private */
		internal var outgoingUnreliableCommands : ENetList;
		/** @private */
		internal var outgoingUnsequencedGroup : int;
		/** @private */
		internal var packetLoss : int;
		/** @private */
		internal var packetLossEpoch : int;
		/** @private */
		internal var packetLossVariance : int;
		/** @private */
		internal var packetThrottle : int;
		/** @private */
		internal var packetThrottleAcceleration : int;
		/** @private */
		internal var packetThrottleCounter : int;
		/** @private */
		internal var packetThrottleDeceleration : int;
		/** @private */
		internal var packetThrottleEpoch : int;
		/** @private */
		internal var packetThrottleInterval : int;
		/** @private */
		internal var packetThrottleLimit : int;
		/** @private */
		internal var packetsLost : int;
		/** @private */
		internal var packetsSent : int;
		/** @private */
		internal var pingInterval : int;
		/** @private */
		internal var reliableDataInTransit : int;
		/** @private */
		internal var roundTripTime : int;
		/** @private */
		internal var roundTripTimeVariance : int;
		/** @private */
		internal var sentReliableCommands : ENetList;
		/** @private */
		internal var sentUnreliableCommands : ENetList;
		/** @private */
		internal var state : int;
		/** @private */
		internal var timeoutLimit : int;
		/** @private */
		internal var timeoutMaximum : int;
		/** @private */
		internal var timeoutMinimum : int;
		/** @private */
		internal var unsequencedWindow : Array;
		public static const UNSEQUENCED_WINDOW_LENGTH : int = 32;
		/** @private */
		internal var windowSize : int;
	}
}
