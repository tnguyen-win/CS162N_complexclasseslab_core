using System;
using CardClasses;

namespace CardTests {
	class Program {
		static void Main() {
			//get its number of dominos remaining
			GetRemainingDominoes();
			Console.WriteLine("\n");
			//get a domino based on its position in the boneyard
			GetDominoByIndex();
			Console.WriteLine("\n");
			//change the domino object in a specific position in the boneyard
			ChangeDominoAtIndex();
			Console.WriteLine("\n");
			//draw or deal a domino from the top of the boneyard
			DrawOrDealDomino();
			Console.WriteLine("\n");
			//get whether it is empty or not
			CheckIfBoneYardIsEmpty();
			Console.WriteLine("\n");
			//shuffle itself
			ShuffleBoneYard();
			Console.WriteLine("\n");
			//convert its attributes to a string for displaying on the screen
			DisplayDominoAttributes();
			Console.WriteLine("");
		}

		static void GetRemainingDominoes() {
			BoneYard bY = new();

			Console.WriteLine("[Get Remaining Dominoes]");
			Console.WriteLine("Expected [52].");
			Console.WriteLine($"Got [{bY.NumCards}].");
		}

		static void GetDominoByIndex() {
			BoneYard bY = new();

			Console.WriteLine("[Get Domino By Index]");
			Console.WriteLine("Expected [Suit: [6] Value: [2]].");
			Console.WriteLine($"Got [{bY[21]}].");
		}

		static void ChangeDominoAtIndex() {
			BoneYard bY = new();

			bY[21].Suit = 4;
			bY[21].Value = 13;

			Console.WriteLine("[Change Domino At Index]");
			Console.WriteLine("Expected [Suit: [4] Value: [13]].");
			Console.WriteLine($"Got [{bY[21]}].");
		}

		static void DrawOrDealDomino() {
			BoneYard bY = new();

			Console.WriteLine("[Draw Or Deal Domino]");
			Console.WriteLine("Expected [Suit: [1] Value: [1]].");
			Console.WriteLine($"Got [{bY.Deal()}].");
		}

		static void CheckIfBoneYardIsEmpty() {
			BoneYard bY = new();

			Console.WriteLine("[Check If Bone Yard Is Empty]");
			Console.WriteLine("Expected [False].");
			Console.WriteLine($"Got [{bY.IsEmpty}].");
		}

		static void ShuffleBoneYard() {
			BoneYard bY = new();

			bY.Shuffle();

			Console.WriteLine("[Shuffle Bone Yard]");
			Console.WriteLine("Expected a RANDOMLY generated bone yard list. Results should vary per program run.");
			Console.WriteLine($"Got [{bY}].");
		}

		static void DisplayDominoAttributes() {
			BoneYard bY = new();

			Console.WriteLine("[Display Domino Attributes]");
			Console.WriteLine("Expected [Suit: [1] Value: [1]\nSuit: [1] Value: [2]\nSuit: [1] Value: [3]].");
			Console.Write("Got [");
			for (var i = 0; i < bY.GetType().GetProperties().Length; i++) Console.WriteLine($"{bY[i]}");
			Console.WriteLine("].");
		}
	}
}