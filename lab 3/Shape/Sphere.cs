using System;
namespace Shape {
	public class Sphere : ThreeDimensionalShape {
		public Point A { get; set; }
		public double Radius { get; set; }
		public Sphere(Point a, double rad) {
			A = a;
			Radius = rad;
		}

		public override void moveTo(double x, double y, double z) {
			A.X = x;
			A.Y = y;
			A.Z = z;
		}

		public override void moveBy(double x, double y, double z) {
			A.X += x;
			A.Y += y;
			A.Z += z;
		}
		public override double getArea() {
			return 4 * Math.PI * Math.Pow(Radius, 2);
		}

		public override double getVolume() {
			return 4/3 * Math.PI * Math.Pow(Radius, 3);
		}
		public override string ToString() {
			return string.Format("Sphere: " + "{2}" + Environment.NewLine +
			                     "Area of a sphere: {3}" + Environment.NewLine +
			                     "Volume of a sphere: {4}" + Environment.NewLine +
			                     "{0} | Radius = {1}" + Environment.NewLine, A, Radius, base.ToString(),getArea(), getVolume());
		}
	}
}
