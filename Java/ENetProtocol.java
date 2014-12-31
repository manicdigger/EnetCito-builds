// Generated automatically with "cito". Do not edit.
package enetcito.lib;

public class ENetProtocol
{
	public ENetProtocol()
	{
		this.header = new ENetProtocolCommandHeader();
	}
	ENetProtocolAcknowledge acknowledge;
	ENetProtocolBandwidthLimit bandwidthLimit;
	ENetProtocolConnect connect;
	byte[] data;
	ENetProtocolDisconnect disconnect;
	ENetProtocolCommandHeader header;
	ENetProtocolPing ping;
	ENetProtocolSendFragment sendFragment;
	ENetProtocolSendReliable sendReliable;
	ENetProtocolSendUnreliable sendUnreliable;
	ENetProtocolSendUnsequenced sendUnsequenced;
	ENetProtocolThrottleConfigure throttleConfigure;
	ENetProtocolVerifyConnect verifyConnect;
}
