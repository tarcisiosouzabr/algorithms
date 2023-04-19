using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Algorithms.Solutions
{
    public class TwoNumberSum
    {
        public int[] Solution(int[] array, int targetSum)
        {
            HashSet<int> nums = new HashSet<int>();
            foreach (var num in array)
            {
                int potentialMatch = targetSum - num;
                if (nums.Contains(potentialMatch))
                    return new int[] { potentialMatch, num };
                else
                    nums.Add(num);
            }
            return new int[0];
        }
    }
}
