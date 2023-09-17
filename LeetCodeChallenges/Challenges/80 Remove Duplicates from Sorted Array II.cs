using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenges.Challenges
{
    public class _80_Remove_Duplicates_from_Sorted_Array_II
    {
		public int RemoveDuplicates(int[] nums)
		{
			Dictionary<int, int> elementCount = new Dictionary<int, int>();

			List<int> newArray = new List<int>();

			foreach (int element in nums)
			{
				if (elementCount.ContainsKey(element))
				{
					elementCount[element]++;
					if (elementCount[element] <= 2)
					{
						newArray.Add(element);
					}
				}
				else
				{
					elementCount[element] = 1;
					newArray.Add(element);
				}
			}

			nums = newArray.ToArray();
			return nums.Length;
		}

		// 2° Solution 

		public int RemoveDuplicates2(int[] nums)
		{
			if (nums.Length < 3) return nums.Length;
			int size = 2;
			for (int i = 2; i < nums.Length; i++)
			{
				if (nums[i] != nums[size - 2])
				{
					nums[size++] = nums[i];
				}
			}
			return size;

		}
	}
}
