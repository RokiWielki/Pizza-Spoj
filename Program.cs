using System;
using System.Text;


namespace Pizza
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var answer = new StringBuilder();
            int T = int.Parse(Console.ReadLine());

            for (int i = 1; i <= T; i++)
            {
                long N = long.Parse(Console.ReadLine());
                answer.AppendLine(Recurence(N).ToString());
            }
            Console.WriteLine(answer.ToString());
        }

    
        static long Recurence(long N)
        {
            if (N == 1)
                return 2;
            return (N * N + N + 2) / 2;
        }

    }

    
}
