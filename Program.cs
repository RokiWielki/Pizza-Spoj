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
            if (1<=T && T<=1000000)
            {
                for (int i = 0; i < T; i++)
                {
                    N[i] = int.Parse(Console.ReadLine());

                }
                for (int i = 0; i < T; i++)
                {
                    N[i] *= T;
                    Console.WriteLine(N[i]);
                }
            }
            
        }

    }
}
