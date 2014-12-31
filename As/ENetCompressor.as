// Generated automatically with "cito". Do not edit.
package
{
	import flash.utils.ByteArray;

	/**
	 * An ENet packet compressor for compressing UDP packets before socket sends or receives.
	 */
	public class ENetCompressor
	{

		/**
		 * Compresses from inBuffers[0:inBufferCount-1], containing inLimit bytes, to outData, outputting at most outLimit bytes. Should return 0 on failure.
		 */
		public function compress(inBuffers : ENetBuffer, inBufferCount : int, inLimit : int, outData : ByteArray, outLimit : int) : int
		{
			throw "Abstract method called";
		}

		/**
		 * Decompresses from inData, containing inLimit bytes, to outData, outputting at most outLimit bytes. Should return 0 on failure.
		 */
		public function decompress(inData : ByteArray, inLimit : int, outData : ByteArray, outLimit : int) : int
		{
			throw "Abstract method called";
		}

		/**
		 * Destroys the context when compression is disabled or the host is destroyed. May be NULL.
		 */
		public function destroy() : void
		{
			throw "Abstract method called";
		}
	}
}
