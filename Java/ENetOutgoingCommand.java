// Generated automatically with "cito". Do not edit.
package enetcito.lib;

public class ENetOutgoingCommand extends ENetListNode
{
	ENetProtocol command;
	ushort fragmentLength;
	int fragmentOffset;

	public final ENetListNode outgoingCommandList()
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
