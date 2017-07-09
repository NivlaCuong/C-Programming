namespace RandomWalker {
	public class RandomEvent {
		public RandomWalker Walker { get; set; }
		public int Direction { set; get; }
		public RandomEvent(RandomWalker r, int dir) {
			Walker = r;
			Direction = dir;
 		}
	}
}
