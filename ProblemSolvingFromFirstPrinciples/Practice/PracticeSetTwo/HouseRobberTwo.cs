using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetTwo
{
    public class HouseRobberTwo
    {
        public int HouseRobberCircular(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            if (nums.Length == 1)
            {
                return nums[0];
            }

            int[] skipLastHouse = new int[nums.Length - 1];
            int[] skipFirstHouse = new int[nums.Length - 1];

            for(int i = 0; i < nums.Length - 1; i++)
            {
                skipLastHouse[i] = nums[i];
                skipFirstHouse[i] = nums[i+1];
            }

            int maxLoot = Math.Max(HouseRobberHelper(skipLastHouse), HouseRobberHelper(skipFirstHouse));
            return maxLoot;
        }

        private int HouseRobberHelper(int[] input)
        {
            if (input.Length == 0)
            {
                return 0;
            }

            if (input.Length == 1)
            {
                return input[0];
            }

            int[] maxLoot = new int[input.Length];

            maxLoot[0] = input[0];
            maxLoot[1] = Math.Max(input[0], input[1]);

            for(int i = 2; i < input.Length; i++)
            {
                maxLoot[i] = Math.Max(maxLoot[i-2]+input[i], maxLoot[i-1]);
            }

            return maxLoot[input.Length - 1];
        }
    }
}