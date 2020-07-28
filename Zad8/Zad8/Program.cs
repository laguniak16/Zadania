using System;
using System.Collections.Generic;

namespace Zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            string lines = Console.ReadLine();
            int number = Int32.Parse(lines);
            int numberOfPrime = 0;
            List<int> score = new List<int>();
            int isPrime = 0;
           
            for (int i = 0; i < number; i++)
            {
                lines = Console.ReadLine();
                string[] spltLines = lines.Split(' ');
                int m = Int32.Parse(spltLines[0]);
                int n = Int32.Parse(spltLines[1]);
                if (n >= m)
                {
                    for (int j = m; j < n; j++)
                    {
                        for (int k = 1; k <= j; k++)
                        {
                            if (j % k == 0)
                            {
                                isPrime++;
                            }
                        }
                        if (isPrime == 2)
                        {
                            numberOfPrime++;
                        }
                        isPrime = 0;
                    }
                    score.Add(numberOfPrime);
                    numberOfPrime = 0;
                }
                else
                    break;
            }
            if (score.Count > 0)
            {
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine(score[i]);
                }
            }
        }
    }
}
