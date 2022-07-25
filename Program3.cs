

namespace ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = new List<int>();
            List<int> list3 = new List<int>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] Add = command.Split().ToArray();
                

                if (Add[0] == "Remove")
                {
                    if (int.Parse(Add[1]) > list.Count)
                    {
                        Console.WriteLine("Invalid index");

                    }
                    else
                    {
                        list.Remove(list[int.Parse(Add[1])]);
                    }
                    
                }

                if (Add[0] == "Add")
                {
                    if (int.Parse(Add[1]) > list.Count)
                    {
                        Console.WriteLine("Invalid index");

                    }
                    else
                    {
                        list.Add(int.Parse(Add[1]));
                    }
                }

                if (Add[0] == "Insert")
                {
                    if (int.Parse(Add[2]) > list.Count)
                    {
                        Console.WriteLine("Invalid index");
                        
                    }
                    else
                    {
                        list.Insert(int.Parse(Add[2]), int.Parse(Add[1]));
                    }
                                      
                }

                if (Add[0] == "Shift")
                {
                    if (int.Parse(Add[2]) > list.Count)
                    {
                        Console.WriteLine("Invalid index");

                    }
                    else
                    {
                        if (Add[1] == "left")
                        {
                            for (int i = 0; i < int.Parse(Add[2]); i++)
                            {
                                list2.Add(list[0]);
                                list.Remove(list[0]);
                                list.Add(list2[i]);

                            }

                        }

                        if (Add[1] == "right")
                        {
                            for (int i = 0; i < int.Parse(Add[2]); i++)
                            {
                                list3.Add(list[list.Count - (i + 1)]);
                                list.Remove(list[list.Count - (i + 1)]);
                                list.Insert(0, list3[i]);
                            }
                        }
                    }
                   
                    
                }

                list2.Clear();
                list3.Clear();
                command = Console.ReadLine();
            }


            Console.WriteLine(string.Join(" ", list));
        }
    }
}