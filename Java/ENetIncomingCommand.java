// Generated automatically with "cito". Do not edit.
package enetcito.lib;

public class ENetIncomingCommand extends ENetListNode
{
	ENetProtocol command;
	int fragmentCount;
	int[] fragments;
	int fragmentsRemaining;

	public final ENetListNode incomingCommandList()
	{
		return this;
	}
	ENetPacket packet;
	ushort reliableSequenceNumber;
	ushort unreliableSequenceNumber;
}
