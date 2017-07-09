using System;
namespace RandomWalker {
	public delegate void Move(RandomEventDelegate r);
	public class RandomWalkerDelegate {
		public event Move moveEvent;
		public bool hasNext = true;
		public void walk() {
			Random random = new Random();
			int ranNum = random.Next(0, 2);
			RandomEventDelegate RE = new RandomEventDelegate(this, ranNum);
			if (moveEvent != null) {
				moveEvent(RE);
			}
			else {
				hasNext = false;
			}
		}
	}
}
