using System;
namespace Shape {
	public abstract class TwoDimensionalShape : Shape {
		public abstract double getArea();
		public override string ToString() {
			return string.Format("TwoDimensionalShape" + Environment.NewLine +
								 "{0}", base.ToString());
		}
	}
}
