using System;

namespace CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First deck:");
            List<int> firstDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine("Second deck:");
            List<int> secondDeck = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sum = 0;
            

            if(firstDeck.Count != secondDeck.Count)
            {
                throw new ArgumentException("Invalid amount of cards!");
            }

            for(; ; )                       
            {
                if (firstDeck[0] > secondDeck[0])
                {
                    firstDeck.Add(firstDeck[0]);
                    firstDeck.Add(secondDeck[0]);                  
                }

                if (secondDeck[0] > firstDeck[0])
                {
                    secondDeck.Add(secondDeck[0]);
                    secondDeck.Add(firstDeck[0]);                   
                }

                firstDeck.RemoveAt(0);
                secondDeck.RemoveAt(0);

                if (firstDeck.Count == 0)
                {
                    sum = secondDeck.Sum();
                    Console.WriteLine("Second player wins! Sum: {0}", sum);
                    break;
                }

                if (secondDeck.Count == 0)
                {
                    sum = firstDeck.Sum();
                    Console.WriteLine("First player wins! Sum: {0}", sum);
                    break;
                }
            }
            
           
        }
    }
}