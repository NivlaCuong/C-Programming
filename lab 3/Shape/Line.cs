using System;
namespace Shape {
	public class Line : OneDimensionalShape {
		public Point A { get; set; }
		public Point B { get; set; }
		public Line(Point a, Point b) {
			A = a;
			B = b;
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
			B.X += x;
			B.Y += y;
			B.Z += z;
		}
		public override double getLength() {
			return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2) + Math.Pow(B.Z - A.Z, 2));
		}
		public override string ToString() {
			return string.Format("Line: " + "{2} " + Environment.NewLine +
			                     "Length of the line: {3}" + Environment.NewLine +
								 "a : {0}" + Environment.NewLine +
			                     "b : {1}", A, B, base.ToString(), getLength());
		}
	}
}
