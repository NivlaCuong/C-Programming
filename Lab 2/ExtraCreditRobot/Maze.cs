using System;
namespace ExtraCreditRobot {
	public class Maze {
		public bool[,] maze = new bool[9,13];
		public string[,] MazeStar = new string[9, 13];
		public Maze() {
			createMaze();
			drawMaze();
		}
		void createMaze() {
			for (int i = 0; i < maze.GetLength(0); i++) {
				for (int j = 0; j < maze.GetLength(1); j++) {
					if ((i == 0 && j != 1)
					    || (j == 0 || j == 12)
					    || (i == 1 && (j == 2 || j == 8))
					    || (i == 2 && (j == 5 || j == 6 || j == 7 || j == 8))
					    || (i == 3 && (j == 3 || j == 2 || j == 4 || j == 10))
					    || (i == 4 && j != 5 && j != 10 && j != 1 && j != 11)
					    || (i == 5 && (j == 7 || j == 9 || j == 11))
					    || (i == 6 && j != 3 && j != 6 && j != 8 && j != 9 && j != 10 && j != 11)
					    || (i == 7 && j != 3 && j != 4 && j != 6 && j != 8 && j != 11)
					    || (i == 8 && j != 11))
						maze[i, j] = true;
				}
			}
		}
		public void drawMaze() {
			for (int i = 0; i < maze.GetLength(0); i++) {
				for (int j = 0; j < maze.GetLength(1); j++) {
					if (maze[i, j]) {
						MazeStar[i, j] = "*";
						continue;
					}
					MazeStar[i, j] = " ";
				}
			}
		}

		public void printMaze() {
			for (int i = 0; i < MazeStar.GetLength(0); i++) {
				for (int j = 0; j < MazeStar.GetLength(1); j++) {
					Console.Write(string.Format("{0} ", MazeStar[i, j]));
				}
				Console.Write(Environment.NewLine);
			}
		}
			
	}
}
