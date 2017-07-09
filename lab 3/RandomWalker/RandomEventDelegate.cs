namespace RandomWalker {
	public class RandomEventDelegate {
		public RandomWalkerDelegate Walker { get; set; }
		public int Direction { set; get; }
		public RandomEventDelegate(RandomWalkerDelegate r, int dir) {
			Walker = r;
			Direction = dir;
		}
	}
}
