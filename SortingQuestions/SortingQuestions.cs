using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace InterwiewQuestions.SortingQuestions
{
    class SortingArrayQuestions
    {
        /// <summary>
        /// You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, 
        /// representing the number of elements in nums1 and nums2 respectively.
        /// The final sorted array should not be returned by the function, 
        /// but instead be stored inside the array nums1. 
        /// To accommodate this, nums1 has a length of m + n, 
        /// where the first m elements denote the elements that should be merged, 
        /// and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
        /// </summary>
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i=0;    
            int j=0;
            while (nums1.Length > i)
            {
                if (nums1[i]==0 & i<m)
                {
                    nums1[i] = nums2[j];
                    j++;
                }
                i++;
            }
            Array.Sort(nums1);
        }
    }
}
