// Generated automatically with "cito". Do not edit.
package
{
	import flash.utils.ByteArray;

	public class ENetIncomingCommand extends ENetListNode
	{
		/** @private */
		internal var command : ENetProtocol;
		/** @private */
		internal var fragmentCount : int;
		/** @private */
		internal var fragments : Array;
		/** @private */
		internal var fragmentsRemaining : int;

		public final function incomingCommandList() : ENetListNode
		{
			return this;
		}
		/** @private */
		internal var packet : ENetPacket;
		/** @private */
		internal var reliableSequenceNumber : int;
		/** @private */
		internal var unreliableSequenceNumber : int;
	}
}
