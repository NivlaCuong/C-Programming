using System;
using System.Collections.Generic;

namespace Shape {
	class MainClass {
		public static void Main(string[] args) {
			Shape Line = new Line(new Point(0, 0, 0), new Point(4, 4, 4));
			Shape Circle = new Circle(new Point(2, 2, 3), 2);
			Shape Sphere = new Sphere(new Point(6, 5, 4), 3);

			List<Shape> list = new List<Shape> { Line, Circle, Sphere};
			Console.WriteLine("-----Current Location-----");
			Console.WriteLine();
			foreach (Shape a in list) {
				Console.WriteLine(a);
				Console.WriteLine();
			}

			//Using MoveBy() function
			foreach (Shape a in list) {
				a.moveBy(1, 2, 3);
			}
			Console.WriteLine("-----New Location using moveBy() Function-----");
			Console.WriteLine();
			foreach (Shape a in list) {
				Console.WriteLine(a);
				Console.WriteLine();
			}

			//Using MoveTo() Function
			foreach (Shape a in list) {
				a.moveTo(7, 5, 10);
			}
			Console.WriteLine("-----New Location using moveTo() Function-----");
			Console.WriteLine();
			foreach (Shape a in list) {
				Console.WriteLine(a);
				Console.WriteLine();
			}
		}
	}
}
