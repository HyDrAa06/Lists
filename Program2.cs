using System;

namespace HouseParty
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of commands:");
            int numOfCommands=int.Parse(Console.ReadLine());

            List<string> peopleGoing=new List<string>();
            List<string> peopleNotGoing=new List<string>();
            List<string> peopleAlreadyGoing = new List<string>();


            for (int i = 0; i < numOfCommands; i++)
            {
               string[] people = Console.ReadLine().Split(" ").ToArray();

                if (people[2] == "not")
                {
                    if (peopleGoing.Contains(people[0]))
                    {
                        peopleGoing.Remove(people[0]);                      
                    }
                    else
                    {
                        peopleNotGoing.Add(people[0]);
                    }
                }

                if(people[2] == "going!")
                {
                    if (peopleGoing.Contains(people[0]))
                    {
                        peopleAlreadyGoing.Add(people[0]);
                    }
                    else
                    {
                        peopleGoing.Add(people[0]);
                    }
                }
                
            }

            for (int j = 0; j < peopleNotGoing.Count; j++)
            {
                Console.WriteLine("{0} is not in the list!", peopleNotGoing[j]);
            }

            for (int j = 0; j < peopleAlreadyGoing.Count; j++)
            {
                Console.WriteLine("{0} is already ont the list!", peopleAlreadyGoing[j]);
            }

            for (int j = 0; j < peopleGoing.Count; j++)
            {
                Console.WriteLine(peopleGoing[j]);
            }
        }
    }
}