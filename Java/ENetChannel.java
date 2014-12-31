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
	ENetList incomingReliableCommands;
	int incomingReliableSequenceNumber;
	ENetList incomingUnreliableCommands;
	int incomingUnreliableSequenceNumber;
	ushort outgoingReliableSequenceNumber;
	ushort outgoingUnreliableSequenceNumber;
	int[] reliableWindows;
	public static final int RELIABLE_WINDOWS_LENGTH = 16;
	int usedReliableWindows;
}
