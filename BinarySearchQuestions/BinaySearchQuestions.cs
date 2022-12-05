using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace InterwiewQuestions.BinarySerach
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
                else if (nums[mid] > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return low;


        }

        public int MySqrt(int x)
        {

            //BRUTE FORCE SOLUTION 
            //int result = 1;
            //int i = 1;

            //while (result <= x)
            //{
            //    i++;
            //    result = i * i;
            //}

            //return i - 1;

            //BINARY SEARCH 
            int start = 0;
            int end = x;
            int mid = 0;

            if (x <= 1)
            {
                return x;
            }

            while (start <= end)
            {
                mid = start + (end - start) / 2;

                if (mid == x / mid)
                {
                    return mid;

                }
                else if (mid > x / mid)
                {

                    end = mid - 1;

                }
                else
                {
                    if (mid + 1 > x / (mid + 1))
                    {
                        return mid;
                    }
                    start = mid + 1;
                }
            }



            return mid;





        }
    }
}
