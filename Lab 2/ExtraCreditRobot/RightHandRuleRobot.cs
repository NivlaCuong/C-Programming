namespace ExtraCreditRobot {
	public class RightHandRuleRobot : Robot {
		
		public RightHandRuleRobot(Maze a) : base(a) {
			maze.MazeStar[row, col] = robot;

			//cantMoveFoward = maze.maze[row + 1, col];
		}
			
		public override void move() {
			maze.MazeStar[row, col] = " ";
			if (cantTurnRight == true) {
				if (cantMoveFoward == true) {
					if (cantTurnLeft == true) {
						dir = Direction.West;
						moveFoward();
					}
					else {
						dir = Direction.East;
						moveFoward();
					}
				}
				else {
					moveFoward();
					cantTurnLeft = maze.maze[row, col + 1];
				}
			}
			else {
				dir = Direction.South;
				moveFoward();

			}
		}

	}
}
	