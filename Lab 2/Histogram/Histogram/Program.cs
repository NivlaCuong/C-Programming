using System;

namespace Histogram
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("These results below will have the following: Counter, total number that falls into that range, and one '*' is equal to 100 numbers");
			Console.WriteLine();
			Random random = new Random();
			Histogram a = new Histogram(0, 1.0);
			for (int i = 0; i < 10000; i++) {
				double number = random.NextDouble();
				a.add(number);
			}
			Console.WriteLine("-----Plot Frequency for 10,000 numbers in range 0 to 1------");
			a.plotFrequency();
			Console.WriteLine();
			Console.WriteLine("-----Plot Cumulate for 10,000 numbers in range 0 to 1-----");
			a.plotCumulative();
			Console.WriteLine();
			Histogram b = new Histogram(10,0,10);
			for (int i = 0; i < 1000; i++) {
				double number = random.NextDouble() * b.max;
				b.add(number);
			}
			Console.WriteLine("-----Plot Frequency for 1,000 numbers in range 0 to 10-----");
			b.plotFrequency();
			Console.WriteLine();
			Console.WriteLine("-----Plot Cumulate for 1,000 numbers in range 0 to 10-----");
			b.plotCumulative();
		}
	}
}
