namespace Shape {
	public abstract class Shape {
		int shapeID;
		static int last = 1000;
		public Shape() {
			last++;
			shapeID = last;
		}
		public int getShapeID() {
			return shapeID;
		}
		public abstract void moveTo(double x, double y, double z);
		public abstract void moveBy(double x, double y, double z);
		public override string ToString() {
			return string.Format("ShapeID: {0}", shapeID);
		}
	}
}
