using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace InterwiewQuestions
{
    public class BinaySearchQuestions
    {
        public int SearchInsertPosition(int[] nums, int target)
        {
            //Given a sorted array of distinct integers and a target value, return the index if the target is found.
            //If not, return the index where it would be if it were inserted in order.
            //You must write an algorithm with O(log n) runtime complexity.

            int high = nums.Length - 1;
            int low = 0;

            while (low <= high)
            {
                var mid = (low + high) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid]>target)
                {
                    high = mid-1;
                }
                else
                {
                    low = mid+1;
                }
            }

            return low;

            
        }
    }
}
