using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenges.Challenges
{
    public class _189_Rotate_Array
    {
        public void Rotate(int[] nums, int k)
        {
            if (nums.Length > 0 && k > 0)
            {
                k = k % nums.Length;

                Array.Reverse(nums);

                Modif(nums, 0, k - 1);

                Modif(nums, k, nums.Length - 1);
            }
        }

        private void Modif(int[] nums, int begin, int end)
        {
            while (begin < end)
            {
                int temp = nums[begin];
                nums[begin] = nums[end];
                nums[end] = temp;
                begin++;
                end--;
            }
        }

        public void Rotate2(int[] nums, int k)
        {
            int size = nums.Length;
            for (int i = 0; i < k; i++)
            {
                int lastElement = nums[size - 1];
                int controle = 0;
                for (int j = 0; j < size; j++)
                {
                    if (j == 0)
                    {
                        controle = nums[j];
                        nums[j] = lastElement;
                    }
                    else
                    {
                        var changed = nums[j];
                        nums[j] = controle;
                        controle = changed;
                    }
                }
            }
        }
    }
}
