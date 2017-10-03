using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeT
{
    internal class PrimeT
    {
        private static bool[] SieveArray;
        private static List<bool> PrimeList;
        private static int range;
        

        private void SieveOfErathosthenes()
        {
            
            for (int i = 2; i*i<=range; i++)
            {
                if (SieveArray[i])
                {
                    for (int j = i*2; j <= range; j+=i)
                    {
                        SieveArray[j] = false;
                    }
                }
            }
        }
        
        public void readList()
        {
            for (int i = 0; i < PrimeList.Count; i++)
            {
                if (PrimeList.ElementAt(i))
                {
                    Console.WriteLine("TAK");
                } else if (PrimeList.ElementAt(i)==false)
                {
                    Console.WriteLine("NIE");
                }
            }
        }

        public void init()
        {
            SieveArray = new bool[range + 1];
            SieveArray = Enumerable.Repeat(true, SieveArray.Length).ToArray();
            SieveArray[1] = false;
            PrimeList = new List<bool>();
        }
        
        
        public static void Main(string[] args)
        {
            PrimeT obj = new PrimeT();

            range = 10000;
            
            obj.init();
            
            obj.SieveOfErathosthenes();

            int quantityOfNumbers = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < quantityOfNumbers; i++)
            {
                int tmp = int.Parse(Console.ReadLine());
                PrimeList.Add(SieveArray[tmp]);
            }
            
            obj.readList();
        }
    }
}