// Generated automatically with "cito". Do not edit.
package enetcito.lib;

public class ENetOutgoingCommand extends ENetListNode
{
	ENetProtocol command;
	int fragmentLength;
	int fragmentOffset;

	public final ENetListNode outgoingCommandList()
	{
		return this;
	}
	ENetPacket packet;
	int reliableSequenceNumber;
	int roundTripTimeout;
	int roundTripTimeoutLimit;
	int sendAttempts;
	int sentTime;
	int unreliableSequenceNumber;
}
