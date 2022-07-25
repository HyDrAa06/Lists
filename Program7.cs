using System;

namespace AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]firstArray=Console.ReadLine().Split("|").ToArray();
            string[] secondArray;
            string[] thirdArray;

            List<int> list = new List<int>();

            for (int i = 0; i < firstArray.Length; i++)
            {
                
                secondArray=firstArray[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                //nadqvam se ne e problem che polzvam tozi metod/funkciq
                for (int j = secondArray.Length - 1; j >= 0; j--)
                {
                    list.Add(int.Parse(secondArray[j]));
                }
            }

            list.Reverse();

            Console.WriteLine(string.Join(" ", list));
        }
    }
}