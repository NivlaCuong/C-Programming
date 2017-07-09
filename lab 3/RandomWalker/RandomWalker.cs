using System;
using System.Collections.Generic;
namespace RandomWalker {
	public class RandomWalker {
		public List<RandomWalkObserver> observerList { get; set; }
		public List<RandomWalkObserver> removeObserverList { get; set; }
		public RandomWalker() {
			observerList = new List<RandomWalkObserver>();
			removeObserverList = new List<RandomWalkObserver>();
		}
		public void addObserver(RandomWalkObserver p) {
			if (!observerList.Contains(p)) {
				observerList.Add(p);
			}
		}
		public void delObserver(RandomWalkObserver p) {
			if (!removeObserverList.Contains(p)) {
				removeObserverList.Add(p);
			}
		}	
		public void move() {
			Random random = new Random();
			for (int i = 0; i < 1000; i++) {
				int ranNum = random.Next(0, 2);
				RandomEvent RE = new RandomEvent(this, ranNum);
				foreach (RandomWalkObserver a in observerList) {
					a.Moved(RE);
				}
				foreach (RandomWalkObserver a in removeObserverList) {
					observerList.Remove(a);
				}
			}
		}


	}
}
