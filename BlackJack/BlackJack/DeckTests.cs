using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CardClasses;

namespace CardTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestDeckConstructor();
            //TestDeckShuffle();
            //TestDeckDeal();

            Console.ReadLine();
        }

        static void TestDeckConstructor()
        {
            Deck d = new Deck();

            Console.WriteLine("Testing deck of cards default constructor");
            Console.WriteLine("NumCards.  Expecting 52. " + d.NumCards);
            Console.WriteLine("IsEmpty.   Expecting false. " + d.IsEmpty);
            Console.WriteLine("ToString.  Expect a ton of cards in order.\n" + d.ToString());
            Console.WriteLine();
        }

        static void TestDeckShuffle()
        {
            Deck d = new Deck();
            d.Shuffle();
            Console.WriteLine("Testing deck of cards shuffle");
            Console.WriteLine("NumCards.  Expecting 52. " + d.NumCards);
            Console.WriteLine("IsEmpty.   Expecting false. " + d.IsEmpty);
            Console.WriteLine("First Card will rarely be the Ace of Clubs. " + d[0]);
            Console.WriteLine("ToString.  Expect a ton of cards in shuffled order.\n" + d.ToString());
            Console.WriteLine();
        }

        static void TestDeckDeal()
        {
            Deck d = new Deck();
            Card c = d.Deal();

            Console.WriteLine("Testing deck of cards deal");
            Console.WriteLine("NumCards.  Expecting 51. " + d.NumCards);
            Console.WriteLine("IsEmpty.   Expecting false. " + d.IsEmpty);
            Console.WriteLine("Dealt Card should be Ace of Clubs. " + c);

            // now let's deal them all and see what happens at the end
            for (int i = 1; i <= 51; i++)
                c = d.Deal();
            Console.WriteLine("Dealt all 52 cards");
            Console.WriteLine("NumCards.  Expecting 0. " + d.NumCards);
            Console.WriteLine("IsEmpty.   Expecting true. " + d.IsEmpty);
            Console.WriteLine("Last Card should be King of Spades. " + c);
            Console.WriteLine("Dealing again should return null. Expecting true. " + (d.Deal() == null));

            Console.WriteLine();
        }
    }
}
