using System;

public class StartUp
{
    public static void Main()
    {
        string command = Console.ReadLine();
        CustomList<string> myList = new CustomList<string>();
        while (command!="END")
        {
            string[] args = command.Split();
            switch (args[0])
            {
                case "Add":
                    myList.Add(args[1]);
                    break;
                case "Remove":
                    myList.Remove(int.Parse(args[1]));
                    break;
                case "Contains":
                    Console.WriteLine(myList.Contains(args[1]));
                     break;
                case "Swap":
                    myList.Swap(int.Parse(args[1]), int.Parse(args[2]));
                    break;
                case "Greater":
                    Console.WriteLine(myList.CountGreaterThan(args[1]));
                    break;
                case "Max":
                    Console.WriteLine(myList.Max());
                    break;
                case "Min":
                    Console.WriteLine(myList.Min());
                    break;
                case "Print":
                    foreach (var variable in myList.Values)
                    {
                        Console.WriteLine(variable);
                    }
                    break;
            }
            command = Console.ReadLine();
        }
    }
}

