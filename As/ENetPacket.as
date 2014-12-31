// Generated automatically with "cito". Do not edit.
package
{
	import flash.utils.ByteArray;

	public class ENetPacket
	{

		public final function getData() : ByteArray
		{
			return this.data;
		}

		public final function getDataLength() : int
		{
			return this.dataLength;
		}

		public final function getFlags() : int
		{
			return this.flags;
		}

		public final function getFreeCallback() : ENetPacketFreeCallback
		{
			return this.freeCallback;
		}

		public final function getReferenceCount() : int
		{
			return this.referenceCount;
		}

		public final function getUserData() : UserData
		{
			return this.userData;
		}

		public final function setData(value : ByteArray) : void
		{
			this.data = value;
		}

		public final function setDataLength(value : int) : void
		{
			this.dataLength = value;
		}

		public final function setFlags(value : int) : void
		{
			this.flags = value;
		}

		public final function setFreeCallback(value : ENetPacketFreeCallback) : void
		{
			this.freeCallback = value;
		}

		public final function setReferenceCount(value : int) : void
		{
			this.referenceCount = value;
		}

		public final function setUserData(value : UserData) : void
		{
			this.userData = value;
		}
		/** @private */
		internal var data : ByteArray;
		/** @private */
		internal var dataLength : int;
		/**
		 * &lt; internal use only
		 */
		internal var flags : int;
		/** @private */
		internal var freeCallback : ENetPacketFreeCallback;
		/** @private */
		internal var referenceCount : int;
		/** @private */
		internal var userData : UserData;
	}
}
