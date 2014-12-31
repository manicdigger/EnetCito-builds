// Generated automatically with "cito". Do not edit.
package enetcito.lib;

public class ENetPeer extends ENetList
{
	public ENetPeer()
	{
		this.acknowledgements = new ENetList();
		this.sentReliableCommands = new ENetList();
		this.sentUnreliableCommands = new ENetList();
		this.outgoingReliableCommands = new ENetList();
		this.outgoingUnreliableCommands = new ENetList();
		this.dispatchedCommands = new ENetList();
		this.unsequencedWindow = new int[32];
	}
	ENetList acknowledgements;
	ENetAddress address;
	int channelCount;
	ENetChannel[] channels;
	int connectID;
	byte[] data;

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
	byte incomingSessionID;
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
	byte outgoingSessionID;
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
	public static final int UNSEQUENCED_WINDOW_LENGTH = 32;
	int windowSize;
}
