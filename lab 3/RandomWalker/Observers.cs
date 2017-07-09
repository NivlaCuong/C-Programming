using System;
namespace RandomWalker {
	public class Observers : RandomWalkObserver{
		public int Min { get; set; }
		public int Max { get; set; }
		public int Pos { get; set; }
		public int TotalStep { get; set; }
		public string dir { get; set; }
		public Observers(int min, int max) {
			Min = min;
			Max = max;
			Pos = 0;
			TotalStep = 0;
			dir = "";
		}

		public void Moved(RandomEvent r) {
			TotalStep++;
			if (r.Direction == 0) {
				dir = "Right";
				Pos++;
			}
			else { 
				Pos--;
				dir = "Left";
			}
			if (Pos == Max || Pos == Min) {
				Console.WriteLine("Total step to move {0} spaces to the {1} is: {2}", Math.Abs(Pos), dir, TotalStep);
				r.Walker.delObserver(this);
			}
		}
		public override string ToString() {
			return string.Format("[Observers: Min = {0}, Max = {1}, current Position = {2}]", Min, Max, Pos);
		}
	}
}
