namespace ExtraCreditRobot {
	public class Robot {
		public Maze maze;
		public int row;
		public int col = 1;
		public enum Direction { North, East, West, South };
		public Direction dir;
		public bool cantTurnRight, cantMoveFoward, cantTurnLeft;
		public string robot = "O";
		public Robot(Maze a) {
			maze = a;
			dir = Direction.South;
			cantTurnRight = maze.maze[row, col - 1];
			cantTurnLeft = maze.maze[row, col + 1];
		}
		public bool lastPosition;
		public virtual void move() {}
		public void moveDown() {
			maze.MazeStar[row + 1, col] = robot;
			row++;
		}

		public void moveUp() {
			maze.MazeStar[row - 1, col] = robot;
			row--;
		}
		public void moveRight() {
			maze.MazeStar[row, col + 1] = robot;
			col++;
			}
		public void moveLeft() {
			maze.MazeStar[row, col - 1] = robot;
			col--;
		}
		public void moveFoward() {
			if (dir == Direction.South)
			{
				moveDown();
				cantTurnRight = maze.maze[row, col - 1];
				cantTurnLeft = maze.maze[row, col + 1];
				cantMoveFoward = maze.maze[row + 1, col];
			}
			else if (dir == Direction.East)
			{
				moveRight();
				cantTurnRight = maze.maze[row + 1, col];
				cantTurnLeft = maze.maze[row - 1, col];
				cantMoveFoward = maze.maze[row, col + 1];

			}
			else if (dir == Direction.North)
			{
				moveUp();

			}
			else {
				moveLeft();
				cantTurnRight = maze.maze[row - 1, col];
				cantTurnLeft = maze.maze[row + 1, col];
				cantMoveFoward = maze.maze[row, col - 1];
			}
		}
	}
}
