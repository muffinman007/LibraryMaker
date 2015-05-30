using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discrete {
	public static class Math{

		/// <summary>
		/// Greatest Common Divisor. Using Euclidean Algorithm.
		/// </summary>
		/// <param name="a">First non-negative integer</param>
		/// <param name="b">Second non-negative integer</param>
		/// <returns>The greatest common divisor</returns>
		/// <exception cref="System.ArgumentException">Thrown when a or b is a negative integer</exception>
		public static int GCD(int a, int b){
			/**
			 * Given two integers A and B with A > B >= 0.
			 * Lemma:
			 * gcd(a, b) = gcd(b, r) if a, b, q, and r are integers with a = b * q + r and 0 <= r < b
			 * gcd(a, 0) = a
			 **/

			if(a < b){
				int temp = a;
				a = b;
				b = temp;
			}
	
			int r = 0;
	
			while(b != 0){
				r = a % b;
				a = b;
				b = r;
			}
	
			return a;
		}
	}
}
