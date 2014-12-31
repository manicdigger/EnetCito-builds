// Generated automatically with "cito". Do not edit.
package enetcito.lib;

/**
 * An ENet packet compressor for compressing UDP packets before socket sends or receives.
 */
public abstract class ENetCompressor
{

	/**
	 * Compresses from inBuffers[0:inBufferCount-1], containing inLimit bytes, to outData, outputting at most outLimit bytes. Should return 0 on failure.
	 */
	public abstract int compress(ENetBuffer inBuffers, int inBufferCount, int inLimit, byte[] outData, int outLimit);

	/**
	 * Decompresses from inData, containing inLimit bytes, to outData, outputting at most outLimit bytes. Should return 0 on failure.
	 */
	public abstract int decompress(byte[] inData, int inLimit, byte[] outData, int outLimit);

	/**
	 * Destroys the context when compression is disabled or the host is destroyed. May be NULL.
	 */
	public abstract void destroy();
}
