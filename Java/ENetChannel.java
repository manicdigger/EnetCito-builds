// Generated automatically with "cito". Do not edit.
package enetcito.lib;

public class ENetChannel
{
	public ENetChannel()
	{
		this.reliableWindows = new int[16];
		this.incomingReliableCommands = new ENetList();
		this.incomingUnreliableCommands = new ENetList();
	}

	public final int getOutgoingReliableSequenceNumber()
	{
		return this.outgoingReliableSequenceNumber;
	}

	public final void setOutgoingReliableSequenceNumber(int value)
	{
		this.outgoingReliableSequenceNumber = value % 65536;
	}
	ENetList incomingReliableCommands;
	int incomingReliableSequenceNumber;
	ENetList incomingUnreliableCommands;
	int incomingUnreliableSequenceNumber;
	private int outgoingReliableSequenceNumber;
	int outgoingUnreliableSequenceNumber;
	int[] reliableWindows;
	public static final int RELIABLE_WINDOWS_LENGTH = 16;
	int usedReliableWindows;
}
