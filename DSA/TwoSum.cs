using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSA
{
//    1. Two Sum
//Given an array of integer nums and an integer target, return
//indices of the two numbers such that they add up to the target.
//You may assume that each input would have exactly one solution,
//and you may not use the same element twice.
//You can return the answer in any order.
//Input: nums = [2, 7, 11, 15], target = 9
//Output: [0,1]
//Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
    public static class TwoSum
    {
        public static int[] getIndexofTargetSum(int[] numbers, int target) {


            for (int i = 0; i < numbers.Length ; i++) {

                for (int j = i + 1 ; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                    {
                       return [i, j];
                    }
                }

            }
            return [0];
        }
            
    }
}
