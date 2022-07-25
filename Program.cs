using System;

namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Passengers in each wagon: ");
            List<int> passengersInWagon = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            Console.WriteLine("Maximal capacity of wagon:");
            int maxCapacity=int.Parse(Console.ReadLine());
            
            
            string command=Console.ReadLine();

            while (command != "end")
            {
                string[] Add = command.Split(" ").ToArray();
                

                if(Add.Length == 1)
                {
                    for (int i = 0; i < passengersInWagon.Count; i++)
                    {
                        if(passengersInWagon[i] + int.Parse(command) <= maxCapacity)
                        {
                            passengersInWagon [i] = passengersInWagon[i] + int.Parse(command);
                            break;
                        }
                    }
                }
                if (Add.Length == 2)
                {
                    passengersInWagon.Add(int.Parse(Add[1]));
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", passengersInWagon));
        }
    }
}