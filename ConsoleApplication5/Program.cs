using System;

namespace ConsoleApplication5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i < 50; i++)
            {
                int count = 0; // to count
                for (int j = i; j<=i; j++
                {
                    if (i % j == 0)
                    {
                        count++;
                        
                    }
                }

                {
                    if (count == 2) // nqs ka 2 plotepjesetues eshte nr i plote
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}