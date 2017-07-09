using System;
namespace Histogram {
	public class Histogram {
		public double max { get; set; }
		public double min { get; set; }
		public int[] counter { get; set; }
		public double[] range { get; set; }
		double Interval {get {return (max + min) / counter.Length; } }

		public Histogram(double min, double max) : this(10, min, max) { }
		public Histogram(int numCounter, double min, double max) {
			double last = min;
			this.max = max;
			this.min = min;
			counter = new int[numCounter];
			range = new double[numCounter];
			for (int i = 0; i < range.Length; i++) {
				range[i] = last + Interval;
				last += Interval;
			}
		}
		public void add(double x) {
			for (int i = 0; i < range.Length; i++) {
				if (i == 0 && x < range[i]) {
					counter[i]++;
				} else if (x < range[i] && x >= range[i - 1]) {
					counter[i]++;
				}
			}
		}
		public void reset() {
			for (int i = 0; i < counter.Length; i++) {
				counter[i] = 0;
			}
		}
		public void plotFrequency() {
			int result = 0;
			for (int i = 0; i < counter.Length; i++) {
				Console.Write("Counter " + i + ": ");
				if (counter[i] > 0) {
					result = counter[i];
					Console.Write(result + " ");
					string star = "";
					for (int j = 0; j < counter[i]; j++) {
						if (j % 100 == 0) {
							star += "*";
						}
					}
					Console.Write(star);

				}
				Console.WriteLine();
			}
		}

		public void plotCumulative() {
			int sum = 0;
			int result = 0;
			for (int i = 0; i < counter.Length; i++) {
				sum += counter[i];
				Console.Write("Counter " + i + ": ");
				result = sum;
				Console.Write(result + " ");
				string star = "";
				for (int j = 0; j < sum + counter[i]; j++) {
					if (j % 100 == 0) {
						star += "*";
					}
				}
				Console.Write(star);
				Console.WriteLine();
			}
		}
	}
}