using System;

namespace ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>list=Console.ReadLine().Split().Select(int.Parse).ToList();

            string command =Console.ReadLine();

            while(command != "end")
            {
                string[] Add = command.Split().ToArray();

                if(Add[0] == "Delete")
                {                    
                    for (int i = 0; i < list.Count; i++)
                    {
                        
                        if (int.Parse(Add[1]) == list[i])
                        {
                            list.Remove(list[i]);
                        }
                    }

                }
                
                if(Add[0] == "Insert")
                {                   
                    list.Insert(int.Parse(Add[2]), int.Parse(Add[1]));
                }
                    
                command = Console.ReadLine();
            }


            Console.WriteLine(string.Join(" ", list));

        }
    }
}