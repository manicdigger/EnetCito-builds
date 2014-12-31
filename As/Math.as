// Generated automatically with "cito". Do not edit.
package
{
	import flash.utils.ByteArray;

	public class Math
	{

		public static function isLessThanUnsigned(n1 : int, n2 : int) : Boolean
		{
			var comp : Boolean = n1 < n2;
			if (n1 < 0 != n2 < 0) {
				comp = !comp;
			}
			return comp;
		}
	}
}
