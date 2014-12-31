// Generated automatically with "cito". Do not edit.
package
{
	import flash.utils.ByteArray;

	public class ENetProtocol
	{
		public function ENetProtocol()
		{
			this.header = new ENetProtocolCommandHeader();
		}
		/** @private */
		internal var acknowledge : ENetProtocolAcknowledge;
		/** @private */
		internal var bandwidthLimit : ENetProtocolBandwidthLimit;
		/** @private */
		internal var connect : ENetProtocolConnect;
		/** @private */
		internal var data : ByteArray;
		/** @private */
		internal var disconnect : ENetProtocolDisconnect;
		/** @private */
		internal var header : ENetProtocolCommandHeader;
		/** @private */
		internal var ping : ENetProtocolPing;
		/** @private */
		internal var sendFragment : ENetProtocolSendFragment;
		/** @private */
		internal var sendReliable : ENetProtocolSendReliable;
		/** @private */
		internal var sendUnreliable : ENetProtocolSendUnreliable;
		/** @private */
		internal var sendUnsequenced : ENetProtocolSendUnsequenced;
		/** @private */
		internal var throttleConfigure : ENetProtocolThrottleConfigure;
		/** @private */
		internal var verifyConnect : ENetProtocolVerifyConnect;
	}
}
