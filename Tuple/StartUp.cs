namespace Tuples
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var inputTokens = Console.ReadLine().Split();
            var names = $"{inputTokens[0]} {inputTokens[1]}";
            var address = inputTokens[2];
            var town = inputTokens[3];
            var namesAdress = new Threeuple<string, string, string>(names, address, town);
            Console.WriteLine(namesAdress);
            inputTokens = Console.ReadLine().Split();
            var name = inputTokens[0];
            var liters = int.Parse(inputTokens[1]);
            var isDrunk = inputTokens[2] == "drunk";
            var nameLiters = new Threeuple<string, int, bool>(name, liters, isDrunk);
            Console.WriteLine(nameLiters);
            inputTokens = Console.ReadLine().Split();
            var person = inputTokens[0];
            var doubleItem = double.Parse(inputTokens[1]);
            var bank = inputTokens[2];
            var tuple = new Threeuple<string, double,string>(person, doubleItem, bank);
            Console.WriteLine(tuple);
            
        }
    }
}