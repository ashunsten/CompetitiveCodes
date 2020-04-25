using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElements
{
    public class Solution
    {
        public int solve(List<int> A)
        {
            //Idea is to use a second array to prevent overflow
            A.Sort();
            List<int> B = new List<int>();
            int sum = 0;
            int total = 0;
            for (int i = 0; i < A.Count(); i++)
            {
                sum = (sum + A[i]) % 1000000007;
                B.Add(sum);
            }

            for (int i = A.Count() - 1; i >= 0; i--)
                total = (total + B[i]) % 1000000007;
            return total;
        }

        public bool TestSolution()
        {
            Solution solution = new Solution();
            var result = solution.solve(new List<int> { 2,1});
            var expectedResult = 4;
            Debug.WriteLine(result);
            return result==expectedResult;

        }
    }
}
