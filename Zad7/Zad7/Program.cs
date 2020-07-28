using System;
using System.Collections.Generic;
using System.Linq;

namespace Zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<uint> list = new List<uint>();
            List<uint> finalList = new List<uint>();
            string output = "";
            int check=0;
            while (true)
            {
                string line = Console.ReadLine();
                char[] c = line.ToCharArray();
                if (char.IsDigit(c[0]))
                {
                    uint number = UInt32.Parse(line);
                    list.Add(number);
                }
                else
                    break; 
            }
            list.Sort();

            for (int i =0; i<list.Count;i++)
            {
                
                if(IsPowerOfTwo(list[i]))
                {
                    check++;
                    finalList.Add(list[i]);
                }
                else
                {
                    finalList.Add(myfunc(list[i]));
                }
            }
            List<uint> dupli = finalList.Distinct().ToList();
            for (int i = 0; i < dupli.Count; i++)
            {
                if(i==dupli.Count-1)
                    output += dupli[i];
                else
                    output += dupli[i] + ", ";
            }
            if (check == 0)
            {
                output = "NA";
            }
            Console.WriteLine(output);
        }
        static uint myfunc(uint x)
        {
            string binary = Convert.ToString(x, 2);
            char[] characters = binary.ToCharArray();
            for (uint i = 1; i < characters.Length; i++)
            {
                if (characters[i] != '0')
                {
                    characters[i] = '0';
                }

            }
            binary = new string(characters);
            x = Convert.ToUInt32(binary, 2);
            return x;
        }
        static bool IsPowerOfTwo(uint x)
        {
            return (x != 0) && ((x & (x - 1)) == 0);
        }
    }
}
