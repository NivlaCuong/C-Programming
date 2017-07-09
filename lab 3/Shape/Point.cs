namespace Shape {
	public class Point : ZeroDimensionalShape {
		public double X { get; set; }
		public double Y { get; set; }
		public double Z { get; set; }
		public Point(double x, double y, double z) {
			X = x;
			Y = y;
			Z = z;
		}
		public override string ToString() {
			return string.Format("Point: X = {0}, Y = {1}, Z = {2}", X, Y, Z);
		}
	}
}
