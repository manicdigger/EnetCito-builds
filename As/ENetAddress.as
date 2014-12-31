// Generated automatically with "cito". Do not edit.
package
{
	import flash.utils.ByteArray;

	public class ENetAddress
	{

		public static function clone(address : ENetAddress) : ENetAddress
		{
			var other : ENetAddress = new ENetAddress();
			other.host = address.host;
			other.port = address.port;
			return other;
		}
		/** @private */
		internal var host : int;
		/** @private */
		internal var port : int;
	}
}
