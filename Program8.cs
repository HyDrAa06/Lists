using System;

namespace AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input:");
            List<string> inputLine=Console.ReadLine().Split(" ").ToList();

            Console.WriteLine("Command:");
            List<string> command = Console.ReadLine().Split(" ").ToList();

            List<string> outputLine1 = new List<string>();
            List<string> tempDivide = new List<string>();


            while (true)
            {
                if (int.Parse(command[1]) > int.Parse(command[2]))
                {
                    throw new ArgumentException("Invalid index.");
                }

                if(int.Parse(command[1]) < -1000 || int.Parse(command[1]) > 1000)
                {
                    throw new ArgumentException("Invalid index.");
                }

                if (int.Parse(command[2]) < -1000 || int.Parse(command[2]) > 1000)
                {
                    throw new ArgumentException("Invalid index.");
                }


                if (command[0] == "merge")
                {
                    for (int i = int.Parse(command[1]); i < int.Parse(command[2]); i++)
                    {
                        outputLine1.Add(inputLine[i] + inputLine[i + 1]);
                        
                    }
                   
                }
                    
                               

                if (command[0] == "divide")
                {
                    string temp1 = inputLine[int.Parse(command[1])];
                    int temp2 = int.Parse(command[2]);
                    int temp3 = temp1.Length/int.Parse(command[2]);
                    int temp4 = temp1.Length%int.Parse(command[2]);
                    for(int i = 0; i < temp2; i++)
                    {
                        if (i == temp2 - 1)
                        {
                            temp3 += temp4;

                        }
                        tempDivide.Add(temp1.Substring(0, temp3));
                        temp1 = temp1.Remove(0, temp3);
                    }
                    
                    outputLine1.InsertRange(int.Parse(command[1]), tempDivide);
                }

                command = Console.ReadLine().Split(" ").ToList();

                if (command[0] == "3:1")
                {
                    break;
                }

            }

            for(int i = 0; i < outputLine1.Count; i++)
            {
                Console.Write(outputLine1[i]);
            }

        }
    }
}