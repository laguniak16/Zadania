using System;

namespace Zad12
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int n = Int32.Parse(line);
            line = Console.ReadLine();
            string[] tab = line.Split(' ');
            int digit = 0;
            int max = 0;
            int score=0;
            for(int i=0;i<n;i++)
            {
                char[] arr = tab[i].ToCharArray();
                for(int j=0;j<arr.Length;j++)
                {
                    digit += Int32.Parse(arr[j].ToString());
                    if(digit>=max)
                    {
                        max = digit;
                        score = i;
                    }
                }
                digit = 0;
            }
            Console.WriteLine(score);
        }
    }
}
