using System;
using System.Text.RegularExpressions;

namespace testy
{
    class Program
    {
        static void Main(string[] args)
        {
            string readLine = Console.ReadLine();
            string line = readLine.ToLower();
            line = String.Concat(Array.FindAll(line.ToCharArray(), Char.IsLetter));
            char[] arr = line.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            bool czy = line.Equals(temp);
            if (czy)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
