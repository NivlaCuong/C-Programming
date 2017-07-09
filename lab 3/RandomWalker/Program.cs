using System;
namespace RandomWalker {
	class MainClass {
		public static void Main(string[] args) {
			RandomWalker walker = new RandomWalker();
			walker.addObserver(new Observers(0, 0));
			walker.addObserver(new Observers(-5, 5));
			walker.addObserver(new Observers(-10, 10));
			walker.addObserver(new Observers(-15, 15));
			walker.addObserver(new Observers(-20, 20));
			walker.addObserver(new Observers(-25, 25));
			walker.addObserver(new Observers(-150, 150));
			Console.WriteLine("Number of Observers in the list after using AddObserver Function: {0}\n", walker.observerList.Count);
			Console.WriteLine("Testing Moved(RandomeEvent) method of the Observer\n");
			walker.move();
			Console.WriteLine("\nTesting the number of Observers left in RandomWalker: {0}\n", walker.observerList.Count);
			foreach (RandomWalkObserver a in walker.observerList) {
				Console.WriteLine(a);
			}

			Console.WriteLine("\nTesting Delegate\n");
			RandomWalkerDelegate WalkerDelegate = new RandomWalkerDelegate();
			WalkerDelegate.moveEvent += new ObserversDelegate(-5, 5).walk;
			WalkerDelegate.moveEvent += new ObserversDelegate(-10, 10).walk;
			WalkerDelegate.moveEvent += new ObserversDelegate(-15, 15).walk;
			WalkerDelegate.moveEvent += new ObserversDelegate(-20, 20).walk;
			WalkerDelegate.moveEvent += new ObserversDelegate(-25, 25).walk;
			WalkerDelegate.moveEvent += new ObserversDelegate(-1000, 1000).walk;
			while (WalkerDelegate.hasNext) {
				WalkerDelegate.walk();
			}
			Console.WriteLine("\nComment:");
			Console.WriteLine("With delegate, the randomWalker will not care about the limit step it can have, \n" +
			                  "but will try to walk until it reached all observers' goals");

		}
	}
}
