using System;

namespace DeckOfCards
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			DeckOfCards original = new DeckOfCards();
			Console.WriteLine("Originial: ");
			Console.WriteLine(original);
			DeckOfCards shuffle = new DeckOfCards();
			shuffle.perfectShuffle();
			int count = 1;
			while (count >= 0) {
				if (original.equals(shuffle)) {
					Console.WriteLine("Final State: ");
					Console.WriteLine(shuffle);
					break;
				}
				Console.WriteLine("Shuffle " + count + ": ");
				Console.WriteLine(shuffle);
				shuffle.perfectShuffle();
				count++;
			}
			Console.WriteLine("Number of shuffle to make the deck become original: " + count);
		}
	}
}
