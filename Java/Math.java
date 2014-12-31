// Generated automatically with "cito". Do not edit.
package enetcito.lib;

public class Math
{

	public static boolean isLessThanUnsigned(int n1, int n2)
	{
		boolean comp = n1 < n2;
		if (n1 < 0 != n2 < 0) {
			comp = !comp;
		}
		return comp;
	}
}
