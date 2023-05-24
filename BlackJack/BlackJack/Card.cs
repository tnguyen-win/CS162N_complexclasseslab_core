using System;

namespace CardClasses {
	public class Card {
		private static readonly Random generator = new();
		private static readonly string[] suits = { "", "Clubs", "Diamonds", "Hearts", "Spades" };
		private static readonly string[] values = { "", "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "Ten", "Jack", "Queen", "King" };
		private int _suit = generator.Next(1, 4);
		private int _value = generator.Next(1, 13);

		public Card() => _suit = _value = 0;

		public Card(int s, int v) {
			_suit = s;
			_value = v;
		}

		public int Suit {
			get => _suit;
			set {
				if (value >= 0 && value <= 4) _suit = value;
				else throw new ArgumentException("Suit _value must be between 0 and 4.");
			}
		}

		public int Value {
			get => _value;
			set {
				if (value >= 0 && value <= 13) _value = value;
				else throw new ArgumentException("Suit _value must be between 0 and 13.");
			}
		}

		/* Groups */
		public bool IsClub(int s) {
			return suits[s] == "Clubs" ? true : false;
		}

		public bool IsDiamond(int s) {
			return suits[s] == "Diamonds" ? true : false;
		}

		public bool IsHeart(int s) {
			return suits[s] == "Hearts" ? true : false;
		}

		public bool IsSpade(int s) {
			return suits[s] == "Spades" ? true : false;
		}

		/* Colors */
		public bool IsBlack(int s) {
			return (suits[s] == "Clubs" || suits[s] == "Spades") ? true : false;
		}

		public bool IsRed(int s) {
			return (suits[s] == "Diamonds" || suits[s] == "Hearts") ? true : false;
		}

		/* Values */
		public bool IsAce(int v) {
			return values[v] == "Ace" ? true : false;
		}

		public bool IsFaceCard(int v) {
			return (values[v] == "Jack" || values[v] == "Queen" || values[v] == "King") ? true : false;
		}

		/* Compare cards */
		public bool HasMatchingSuit(Card other) {
			return _suit == other.Suit ? true : false;
		}

		public bool HasMatchingValue(Card other) {
			return _value == other.Value ? true : false;
		}

		public override string ToString() {
			return $"Suit: [{_suit}] Value: [{_value}]";
		}
	}
}