using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenges.Challenges
{
    public class _169_Majority_Element
    {
        public int MajorityElement(int[] nums)
        {
            if (nums.Length == 0) return 0;
            Array.Sort(nums);
            int last = nums[0];
            int countActual = 0;
            int majority = 0;
            int number = 0;
            foreach (int element in nums)
            {
                if (last == element)
                {
                    countActual++;
                }
                else
                {
                    last = element;
                    countActual = 1;
                }

                if (countActual > majority)
                {
                    majority = countActual;
                    number = element;
                }
            }

            return number;
        }
    }
}
