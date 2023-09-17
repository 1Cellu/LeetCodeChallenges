using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenges.Challenges
{
    public class _26_Remove_Duplicates_from_Sorted_Array
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            int last = 101;
            int size = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (last != nums[i])
                {
                    last = nums[i];
                    nums[size] = nums[i];
                    size++;
                }
            }
            return size;
        }
    }
}
