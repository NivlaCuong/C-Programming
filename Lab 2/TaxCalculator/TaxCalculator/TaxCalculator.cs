using System;
namespace TaxCalculator {
	public class TaxCalculator {
		public double[] IncomeList { get; set; }
		public double[] TaxList { get; set; }
		public double GrossIncome { get; set; }
		public double Tax { get { return taxCalculate(GrossIncome);} }
		public double NetIncome { get { return GrossIncome - Tax; } }
		public TaxCalculator()
			: this(new double[] { 30000, 50000, 100000, 200000, 250000, Double.PositiveInfinity },
				   new double[] { 0.0, .1, .20, .30, .35, .40 }) {}
		public TaxCalculator(double[] incomeList, double[] taxList) {
			IncomeList = incomeList;
			TaxList = taxList;
		}
		public double taxCalculate(double inp) {
			double tax = 0;
			int count = 0;
			double[] newList = new double[IncomeList.Length];
			for (int i = 0; i < newList.Length; i++) {
				if (inp > IncomeList[i]) {
					count++;
				}
			}
			for (int i = count; i >= 0; i--) {
				if (i == 0) {
					newList[i] = inp;
				}
				else {
					newList[i] = inp - IncomeList[i - 1];
					inp = IncomeList[i - 1];
				}
			}
			for (int i = 0; i < count + 1; i++) {
				tax += newList[i] * TaxList[i];
			}
			return tax;
		}
		public string ListToString(double[] list) {
			string result = "[";
			for (int i = 0; i < list.Length; i++) {
				if (i == list.Length - 1) {
					result += list[i] + "]";
				}
				else {
					result += list[i] + ", ";
				}
			}
			return result;
		}
		public override string ToString() {
			return string.Format("IncomeList = {0}" + Environment.NewLine +
			                     "TaxList = {1}" + Environment.NewLine +
			                     "GrossIncome = {2}" + Environment.NewLine +
			                     "Tax = {3}" + Environment.NewLine +
			                     "NetIncome = {4}", ListToString(IncomeList), ListToString(TaxList), 
			                     GrossIncome, Tax, NetIncome);
		}
	}
}