// Generated automatically with "cito". Do not edit.
package enetcito.lib;

public class ENetPacket
{

	public final byte[] getData()
	{
		return this.data;
	}

	public final int getDataLength()
	{
		return this.dataLength;
	}

	public final int getFlags()
	{
		return this.flags;
	}

	public final ENetPacketFreeCallback getFreeCallback()
	{
		return this.freeCallback;
	}

	public final int getReferenceCount()
	{
		return this.referenceCount;
	}

	public final UserData getUserData()
	{
		return this.userData;
	}

	public final void setData(byte[] value)
	{
		this.data = value;
	}

	public final void setDataLength(int value)
	{
		this.dataLength = value;
	}

	public final void setFlags(int value)
	{
		this.flags = value;
	}

	public final void setFreeCallback(ENetPacketFreeCallback value)
	{
		this.freeCallback = value;
	}

	public final void setReferenceCount(int value)
	{
		this.referenceCount = value;
	}

	public final void setUserData(UserData value)
	{
		this.userData = value;
	}
	byte[] data;
	int dataLength;
	/**
	 * &lt; internal use only
	 */
	int flags;
	ENetPacketFreeCallback freeCallback;
	int referenceCount;
	UserData userData;
}
