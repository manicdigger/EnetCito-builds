// Generated automatically with "cito". Do not edit.
package
{
	import flash.utils.ByteArray;

	public class ENetList extends ENetListNode
	{
		public function ENetList()
		{
			this.setSentinel(new ENetListNode());
		}

		public final function getSentinel() : ENetObject
		{
			return this.next;
		}

		public final function setSentinel(value : ENetObject) : void
		{
			this.next = value;
		}
	}
}
