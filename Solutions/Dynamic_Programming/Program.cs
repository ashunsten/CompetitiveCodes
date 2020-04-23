using System;
using isSubsequence;

namespace Dynamic_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new isSubsequence.Solution();
            var result = solution.IsSubsequence( new string("suh"), new string("Asthoou"));
            Console.WriteLine(result);

        }
    }
}
