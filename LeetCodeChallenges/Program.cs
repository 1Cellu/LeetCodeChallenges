#region Merge Sorted Array
//public class Solution {
//    public void Merge(int[] nums1, int m, int[] nums2, int n)
//    {
//        var Ultimo = n + m - 1;
//        while(Ultimo >= 0 && n > 0){
//            nums1[Ultimo] = nums2[n - 1];
//            n--;
//            Ultimo--;
//        }
//        Array.Sort(nums1);
//    }
//}
#endregion

#region Remove Element
//public class Solution
//{
//    public int RemoveElement(int[] nums, int val)
//    {
//        if (nums.Length == 0)
//        {
//            return 0;
//        }

//        int size = 0;
//        for (int i = 0; i < nums.Length; i++)
//        {
//            if (nums[i] != val)
//            {
//                nums[size] = nums[i];
//                size++;
//            }
//        }
//        return size;
//    }
//}

#endregion

#region Remove Duplicates from Sorted Array
//public class Solution
//{
//    public int RemoveDuplicates(int[] nums)
//    {
//        if (nums.Length == 0)
//        {
//            return 0;
//        }

//        int last = 101;
//        int size = 0;
//        for (int i = 0; i < nums.Length; i++)
//        {
//            if (last != nums[i])
//            {
//                last = nums[i];
//                nums[size] = nums[i];
//                size++;
//            }
//        }
//        return size;
//    }
//}
#endregion


#region 80. Remove Duplicates from Sorted Array II
//public class Solution
//{
//    public int RemoveDuplicates(int[] nums)
//    {
//        Dictionary<int, int> elementCount = new Dictionary<int, int>();

//        List<int> newArray = new List<int>();

//        foreach (int element in nums)
//        {
//            if (elementCount.ContainsKey(element))
//            {
//                elementCount[element]++;
//                if (elementCount[element] <= 2)
//                {
//                    newArray.Add(element);
//                }
//            }
//            else
//            {
//                elementCount[element] = 1;
//                newArray.Add(element);
//            }
//        }

//        nums = newArray.ToArray();
//        return nums.Length;
//    }
//}

// 2° Solution 

//public class Solution
//{
//    public int RemoveDuplicates(int[] nums)
//    {
//        if (nums.Length < 3) return nums.Length;
//        int size = 2;
//        for (int i = 2; i < nums.Length; i++)
//        {
//            if (nums[i] != nums[size - 2])
//            {
//                nums[size++] = nums[i];
//            }
//        }
//        return size;

//    }
//}

#endregion