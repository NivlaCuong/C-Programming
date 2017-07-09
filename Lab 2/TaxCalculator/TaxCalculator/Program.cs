using System;

namespace TaxCalculator
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			TaxCalculator a = new TaxCalculator();
			a.GrossIncome = 260000;
			Console.WriteLine("----------Testing ToString() method for taxCalculator a----------");
			Console.WriteLine(a);
			TaxCalculator b = new TaxCalculator();
			b.IncomeList = new double[]{ 15000, 30000, 75000, 100000, 200000};
			b.TaxList = new double[]{ 0.1, 0.15, .2, .3, .4, .5};
			b.GrossIncome = 101000;
			Console.WriteLine("----------Testing Set + Get Properties for all function of TaxCalculator b----------");
			Console.WriteLine("Income Interval: " + b.ListToString(b.IncomeList));
			Console.WriteLine("Tax Interval: " + b.ListToString(b.TaxList));
			Console.WriteLine("Gross Income: " + b.GrossIncome);
			Console.WriteLine("Tax: " + b.Tax);
			Console.WriteLine("Net Income: " + b.NetIncome);
		}
	}
}
