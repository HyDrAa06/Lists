using System;

namespace BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers: ");   
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            Console.WriteLine("Special number and its power: ");
            int[]bomb = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb[0])
                {                  
                    
                    if(i + bomb[1] >= numbers.Count)
                    {
                        for(int j = 0; j < (i + bomb[1])-numbers.Count; j++)
                        {
                            numbers.Add(0);
                        }
                        
                    }

                    if (i - bomb[1] < 0)
                    {
                        for (int j = 0; j > i - bomb[1]; j--)
                        {
                            numbers.Insert(0, 0);
                        }
                        
                    }

                    for (int j = 0; j < bomb[1]; j++)
                    {                        
                        numbers.RemoveAt(i + 1);                            
                    }

                    for (int j = 0; j <= bomb[1]; j++)
                    {                           
                        numbers.RemoveAt(i - 1);
                    }                                      
                }
            }

        

           Console.WriteLine("Their sum:");
           Console.WriteLine(numbers.Sum());
        }
    }
}