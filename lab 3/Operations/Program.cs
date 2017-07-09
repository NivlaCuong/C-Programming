using System;

namespace Operations {
	class MainClass {
		public static void Main(string[] args) {
			Fractions a = new Fractions(2, 5);	
			Fractions b = new Fractions(4, 7);
			Fractions c;
			Fractions temp;
			bool eq;

			Console.WriteLine("----------Testing all operations including Simplify----------");
			c = a + b;
			Console.WriteLine("c = a + b = {0} + {1} = {2}\n", a.printFraction(), b.printFraction(), c.printFraction());
			c = a - b;
			Console.WriteLine("c = a - b = {0} - {1} = {2}\n", a.printFraction(), b.printFraction(), c.printFraction());
			c = a * b;
			Console.WriteLine("c = a * b = {0} * {1} = {2}\n", a.printFraction(), b.printFraction(), c.printFraction());
			c = a / b;
			Console.WriteLine("c = a / b = {0} / {1} = {2}\n", a.printFraction(), b.printFraction(), c.printFraction());
			temp = a;
			a += b;
			Console.WriteLine("a += b ==> a = {0} + {1} = {2}\n", temp.printFraction(), b.printFraction(), a.printFraction());
			temp = b;
			b -= a;
			Console.WriteLine("b -= a ==> b = {0} - {1} = {2}\n", temp.printFraction(), a.printFraction(), b.printFraction());
			temp = c;
			c *= a;
			Console.WriteLine("c *= b ==> c = {0} * {1} = {2}\n", temp.printFraction(), b.printFraction(), c.printFraction());
			temp = a;
			a /= b;
			Console.WriteLine("a /= b ==> a = {0} / {1} = {2}\n", temp.printFraction(), b.printFraction(), a.printFraction());

			Console.WriteLine("----------Testing Equality----------");
			eq = c > b;
			Console.WriteLine("c > b = {0} > {1} : {2}\n", c.printFraction(), b.printFraction(), eq);
			eq = c < b;
			Console.WriteLine("c < b = {0} < {1} : {2}\n", c.printFraction(), b.printFraction(), eq);
			eq = a >= c;
			Console.WriteLine("a >= c = {0} >= {1} : {2}\n", a.printFraction(), c.printFraction(), eq);
			eq = a <= c;
			Console.WriteLine("a <= c = {0} <= {1} : {2}\n", a.printFraction(), c.printFraction(), eq);
			eq = a == c;
			Console.WriteLine("a == c = {0} == {1} : {2}\n", a.printFraction(), c.printFraction(), eq);
			eq = c != b;
			Console.WriteLine("c != b = {0} != {1} : {2}\n", c.printFraction(), b.printFraction(), eq);
			eq = c.Equals(a);
			Console.WriteLine("c.Equals(a) : {0} equals {1} ? --> {2}\n", c.printFraction(), a.printFraction(), eq);

			Console.WriteLine("----------Testing Conversion----------");
			Fractions d = (Fractions)12;
			Console.WriteLine("Fractions d = (Fractions)12 : {1} = {0} //explicit conversion\n", d.printFraction(), 12);
			int x = a;
			Console.WriteLine("int x = a : {0} = {1} //implicit conversion\n", a.printFraction(), x);
			float y = a;
			Console.WriteLine("float y = a : {0} = {1} //implicit conversion\n", a.printFraction(), y);
		}
	}
}
