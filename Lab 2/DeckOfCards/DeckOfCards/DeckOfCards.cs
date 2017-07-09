using System;
namespace DeckOfCards {
	public class DeckOfCards {
		Card[] deck = new Card[52];
		string[] value = new string[13];
		string[] suit = new string[4];
		int cardValue = 2;

		public class Card {
			public Card(string value, string type) {
				Value = value;
				Type = type;
			}
			public string Value {get; set; }
			public string Type {get; set; }
			public override string ToString() {
				return Value + Type;
			}
		}
		public DeckOfCards() {
			setValueCard();
			setSuits();
			for (int i = 0; i < deck.Length; i++) {
				deck[i] = new Card(value[i % value.Length], suit[i / value.Length]);
			}
		}
		void setValueCard() {
			for (int i = 0; i < value.Length; i++) {
				if (i == 0) {
					value[i] = "A";
				}
				else if (i == 10) {
					value[i] = "J";
				}
				else if (i == 11) {
					value[i] = "Q";
				}
				else if (i == 12) {
					value[i] = "K";
				}
				else {
					value[i] = cardValue.ToString();
					cardValue++;
				}
			}
		}
		void setSuits() {
			suit[0] = "H";
			suit[1] = "C";
			suit[2] = "D";
			suit[3] = "S";
		}
		public Card indexer(int pos) { return deck[pos];}
		public bool equals(DeckOfCards aDeck) {
			for (int i = 0; i < aDeck.deck.Length; i++) {
				if (aDeck.firstLine != firstLine || 
				    aDeck.secondLine != secondLine ||
				    aDeck.thirdLine != thirdLine ||
				    aDeck.fourthLine != fourthLine) {
					return false;
				}
			}
			return true;
		}
		public void perfectShuffle() {
			Card[] result = new Card[52];
			Card[] firstHalf = new Card[26];
			Card[] otherHalf = new Card[26];
			int count = 0;
			int index = 0;
			for (int i = 0; i < deck.Length; i++)
			{
				if (i < deck.Length / 2)
				{
					firstHalf[i] = deck[i];
					continue;
				}
				otherHalf[index] = deck[i];
				index++;
			}
			for (int i = 0; i < deck.Length; i++)
			{
				if (i % 2 == 0)
				{
					result[i] = firstHalf[count];
					continue;
				}
				result[i] = otherHalf[count];
				count++;
			}
			deck = result;
		}
		public override string ToString() {
			return String.Format( 
				"{0} " + Environment.NewLine +
				"{1} " + Environment.NewLine +
				"{2} " + Environment.NewLine +
				"{3} " + Environment.NewLine,
				firstLine, secondLine, thirdLine, fourthLine);
		}
		public string firstLine {
			get {
				string first = "";
				for (int i = 0; i < 13; i++) {
					first += deck[i] + " ";
				}
				return first;
			}
		}
		public string secondLine {
			get {
				string second = "";
				for (int i = 13; i < 26; i++) {
					second += deck[i] + " ";
				}
				return second;
			}
		}
		public string thirdLine { 
			get {
				string third = "";
				for (int i = 26; i < 39; i++) {
					third += deck[i] + " ";
				}
				return third;
			}
		}
		public string fourthLine {
			get {
				string fourth = "";
				for (int i = 39; i < 52; i++) {
					fourth += deck[i]+ " ";
				}
				return fourth;
			}
		}
	}
}