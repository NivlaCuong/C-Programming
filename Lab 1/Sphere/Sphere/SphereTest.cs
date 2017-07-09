using System;
namespace Sphere
{
	public class SphereTest
	{
		public static void Main(string[] args)
		{
			Sphere s = new Sphere();
			s.X = 10;
			s.Y = 15;
			s.Z = 20;
			s.Radius = 15.5;
			System.Console.WriteLine(s.X); 
			System.Console.WriteLine(s.Y); 
			System.Console.WriteLine(s.Z); 
			System.Console.WriteLine(s.Radius); 

			System.Console.WriteLine(s.volume()); 
			System.Console.WriteLine(s.surfaceArea());
		}
	}
}
