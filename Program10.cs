using System;

namespace SofUniCoursePlanning
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Lessons:");
            List<string> lessons = Console.ReadLine().Split(", ").ToList();

            Console.WriteLine("Command:");
            List<string> command = Console.ReadLine().Split(":").ToList();

            string insertText="pppppppppppppppppp";

            while (command[0]!="course start")
            {
                if (command[0] == "Add")
                {
                    if (lessons.Contains(command[1]) == false)
                    {
                        lessons.Add(command[1]);
                    }
                   
                }

                if (command[0] == "Insert")
                {
                 
                    if (lessons.Contains(command[1])==false)
                    {
                        lessons.Insert(int.Parse(command[2]), command[1]);
                    }
                    
                   
                }

                if(command[0] == "Remove")
                {
                    if (lessons.Contains(command[1]))
                    {
                        lessons.Remove(command[1]);
                    }
                }


                if (command[0] == "Exercise")
                {
                    insertText = command[1] + "-Exercise";
                    if (lessons.Contains(command[1]))
                    {

                        lessons.Insert(lessons.IndexOf(command[1]) + 1, insertText);
                    }
                    else
                    {

                        lessons.Add(command[1]);
                        lessons.Add(insertText);
                    }
                }


                if (command[0] == "Swap")
                {
                    if (lessons.Contains(command[1]) && lessons.Contains(command[2]))
                    {
                        int temp = lessons.IndexOf(command[1]);
                        int temp2 = lessons.IndexOf(command[2]);
                        lessons[temp] = command[2];
                        lessons[temp2] = command[1];

                        if (insertText.Contains(command[1]))
                        {
                           
                            string temp3 = insertText;
                            lessons[temp] = command[2];
                            lessons[temp2] = command[1];
                            lessons.Remove(insertText);
                            lessons.Insert(temp + 1, temp3);
                        }
                        if (insertText.Contains(command[2]))
                        {
                            
                            string temp3 = insertText;
                            lessons[temp] = command[2];
                            lessons[temp2] = command[1];
                            lessons.Remove(insertText);
                            lessons.Insert(temp2 + 1, temp3);
                        }
                    }                                         
                    
                }


                Console.WriteLine("Command:");
                command = Console.ReadLine().Split(":").ToList();
            }
            for (int i = 0; i <lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }

        }
    }
}