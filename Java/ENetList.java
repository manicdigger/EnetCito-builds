// Generated automatically with "cito". Do not edit.
package enetcito.lib;

public class ENetList extends ENetListNode
{
	public ENetList()
	{
		this.setSentinel(new ENetListNode());
	}

	public final ENetObject getSentinel()
	{
		return this.next;
	}

	public final void setSentinel(ENetObject value)
	{
		this.next = value;
	}
}
