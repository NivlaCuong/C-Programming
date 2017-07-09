using System;
namespace Sphere
{
	public class Sphere
	{
		public int X {
			get;
			set;
		}

		public int Y
		{
			get;
			set;
		}

		public int Z
		{
			get;
			set;
		}

		public double Radius
		{
			get;
			set;
		}

		public double volume()
		{
			return 4 * Math.PI * Math.Pow(Radius, 3) / 3;
		}

		public double surfaceArea()
		{
			return 4 * Math.PI * Math.Pow(Radius, 2);
		}
	}
}

