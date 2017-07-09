using System;
namespace Shape {
	public abstract class ThreeDimensionalShape : Shape {
		public abstract double getArea();
		public abstract double getVolume();
		public override string ToString() {
			return string.Format("ThreeDimensionalShape" + Environment.NewLine +
			                     "{0}", base.ToString());
		}
	}
}
