using System;
namespace Shape {
	public abstract class OneDimensionalShape : Shape {
		public abstract double getLength();
		public override string ToString() {
			return string.Format("OneDimensionalShape" + Environment.NewLine +
								 "{0}", base.ToString());
		}
	}
}
