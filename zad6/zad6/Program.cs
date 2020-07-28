using System;

namespace Zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            string[] firstRow = first.Split(' ');
            string[] secondRow = second.Split(' ');

            
            
            int k = 0;
            for(int i=0;i<firstRow.Length;i++)
            {
                for (int j = 0; j < secondRow.Length; j++)
                {
                    if (firstRow[i].Equals(secondRow[j]))
                    {
                        
                        k++;
                        secondRow[j] = secondRow[j].Remove(0);
                        break;
                    }
                }
            }
            if (k == 11)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
