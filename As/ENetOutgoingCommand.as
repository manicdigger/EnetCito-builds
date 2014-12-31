// Generated automatically with "cito". Do not edit.
package
{
	import flash.utils.ByteArray;

	public class ENetOutgoingCommand extends ENetListNode
	{
		/** @private */
		internal var command : ENetProtocol;
		/** @private */
		internal var fragmentLength : int;
		/** @private */
		internal var fragmentOffset : int;

		public final function outgoingCommandList() : ENetListNode
		{
			return this;
		}
		/** @private */
		internal var packet : ENetPacket;
		/** @private */
		internal var reliableSequenceNumber : int;
		/** @private */
		internal var roundTripTimeout : int;
		/** @private */
		internal var roundTripTimeoutLimit : int;
		/** @private */
		internal var sendAttempts : int;
		/** @private */
		internal var sentTime : int;
		/** @private */
		internal var unreliableSequenceNumber : int;
	}
}
