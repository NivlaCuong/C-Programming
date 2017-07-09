using System;
namespace RandomWalker {
	public interface RandomWalkObserver {
		void Moved(RandomEvent r);
	}
}
