using System;
namespace Shape {
	public class Circle : TwoDimensionalShape  {
		public Point A { get; set; }
		public double Radius { get; set; }
		public Circle(Point a, double rad) {
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
			return Math.PI * Math.Pow(Radius, 2);
		}

		public override string ToString() {
			return string.Format("Circle: " + "{2} " + Environment.NewLine +
			                     "Area of a circle: {3}" + Environment.NewLine +
			                     "{0} | Radius = {1}" + Environment.NewLine, A, Radius, base.ToString(),getArea());
		}
	}
}
