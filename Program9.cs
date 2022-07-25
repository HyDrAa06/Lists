using System;

namespace PokemonDontGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current positions:");
            List<int> currentPosition = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            int temp;
            int sum = 0;

            Console.WriteLine("Index of captured pokemon:");

            while (currentPosition.Count>0)
            {
                int removePosition = int.Parse(Console.ReadLine());

                if (removePosition < 0)
                {
                    temp = currentPosition[0];                   
                    currentPosition[0] = currentPosition[currentPosition.Count - 1];
                    sum = sum + temp;

                    for (int i = 0; i < currentPosition.Count; i++)
                    {
                        if (currentPosition[i] <= temp)
                        {
                            currentPosition[i] = currentPosition[i] + temp;
                        }

                        else
                        {
                            currentPosition[i] = currentPosition[i] - temp;
                        }

                    }

                }

                if (removePosition > currentPosition.Count - 1)
                {
                    temp = currentPosition[currentPosition.Count-1];
                    currentPosition[currentPosition.Count - 1] = currentPosition[0];
                    sum = sum + temp;

                    for (int i = 0; i < currentPosition.Count; i++)
                    {
                        if (currentPosition[i] <= temp)
                        {
                            currentPosition[i] = currentPosition[i] + temp;
                        }

                        else
                        {
                            currentPosition[i] = currentPosition[i] - temp;
                        }

                    }


                }

                else
                {
                    temp = currentPosition[removePosition];
                    currentPosition.RemoveAt(removePosition);
                    sum = sum + temp;

                    for (int i = 0; i < currentPosition.Count; i++)
                    {
                        if (currentPosition[i] <= temp)
                        {
                            currentPosition[i] = currentPosition[i] + temp;                                                      
                        }

                        else
                        {
                            currentPosition[i] = currentPosition[i] - temp;                         
                        }
                        
                    }
                    
                    
                }                               
            }

            
            Console.WriteLine("Sum: {0}",sum);
        }
    }
}
