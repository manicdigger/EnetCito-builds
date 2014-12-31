// Generated automatically with "cito". Do not edit.
package
{
	import flash.utils.ByteArray;

	public class ENetChannel
	{
		public function ENetChannel()
		{
			this.reliableWindows = new Array(16);
			this.incomingReliableCommands = new ENetList();
			this.incomingUnreliableCommands = new ENetList();
		}

		public final function getOutgoingReliableSequenceNumber() : int
		{
			return this.outgoingReliableSequenceNumber;
		}

		public final function setOutgoingReliableSequenceNumber(value : int) : void
		{
			this.outgoingReliableSequenceNumber = value % 65536;
		}
		/** @private */
		internal var incomingReliableCommands : ENetList;
		/** @private */
		internal var incomingReliableSequenceNumber : int;
		/** @private */
		internal var incomingUnreliableCommands : ENetList;
		/** @private */
		internal var incomingUnreliableSequenceNumber : int;
		private var outgoingReliableSequenceNumber : int;
		/** @private */
		internal var outgoingUnreliableSequenceNumber : int;
		/** @private */
		internal var reliableWindows : Array;
		public static const RELIABLE_WINDOWS_LENGTH : int = 16;
		/** @private */
		internal var usedReliableWindows : int;
	}
}
