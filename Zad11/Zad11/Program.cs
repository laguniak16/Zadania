using System;

namespace Zad11
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int n = Int32.Parse(line);
            int digit = 0;
            
            if (n<=20 && n>=2)
            {
                int[] count = new int[10];
                line = Console.ReadLine();
                string[] tab = line.Split(' ');
                string score ="";
                for (int i = 0; i < n; i++)
                {
                    score += tab[i];
                }
                char[] arr = score.ToCharArray();
                for (int i =0;i<10;i++)
                {
                    for (int y = 0; y < arr.Length; y++)
                    {
                        if (Int32.Parse(arr[y].ToString()).Equals(i))
                            count[i]++;
                    }
                }

                int max = 0;
                for (int i=0;i<10;i++)
                {
                    if(max<=count[i])
                    {
                        max = count[i];
                        digit = i;
                    }
                   
                }

                Console.WriteLine(digit);

            }
        }
    }
}
