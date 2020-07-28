using System;

namespace Zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string line = Console.ReadLine();
            int n = Int32.Parse(number);
            string[] order = line.Split(' ');
            Array.Reverse(order);
            for (int i = 0; i < n; i++)
                Console.Write(order[i] + " ");
        }
    }
}
