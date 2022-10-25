using System;
using System.Collections.Generic;


namespace Pizza
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int T=int.Parse(Console.ReadLine());
            int[] N = new int[T];
            for (int i = 0; i < T; i++)
            {
                N[i] = int.Parse(Console.ReadLine());
                
            }
            for (int i = 0; i < T; i++)
            {
                N[i] *= 2;
                Console.WriteLine(N[i]);
            }
        }

    }
}
