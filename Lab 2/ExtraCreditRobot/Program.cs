using System;

namespace ExtraCreditRobot {
	class MainClass {
		public static void Main(string[] args) {
			Maze a = new Maze();
			Robot RighthandRobot = new RightHandRuleRobot(a);
			RighthandRobot.maze.printMaze();
			while (RighthandRobot.lastPosition == false) {
				RighthandRobot.move();
				Console.WriteLine();
				Console.WriteLine();
				RighthandRobot.maze.printMaze();
			}
			Console.WriteLine();
			Console.WriteLine("Your Robot has escaped the maze.");
		}
	}
}
