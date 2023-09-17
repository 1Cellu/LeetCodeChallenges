using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenges.Challenges
{
    public class _88_Merge_Sorted_Array
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var ultimo = n + m - 1;
            while (ultimo >= 0 && n > 0)
            {
                nums1[ultimo] = nums2[n - 1];
                n--;
                ultimo--;
            }
            Array.Sort(nums1);
        }
    }
}
