// Generated automatically with "cito". Do not edit.
package enetcito.lib;

public class ENetAddress
{

	public static ENetAddress clone(ENetAddress address)
	{
		ENetAddress other = new ENetAddress();
		other.host = address.host;
		other.port = address.port;
		return other;
	}
	int host;
	int port;
}
