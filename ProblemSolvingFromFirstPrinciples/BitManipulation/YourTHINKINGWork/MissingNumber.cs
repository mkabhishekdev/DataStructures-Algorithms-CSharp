using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewLabCodeRepo.Interview
{
    /* My Approach
    1. get the count of the int[]
    2. try to find out if all the values from [0,n] exists in nums[]
    3. if any value missing, return that number
    4. else return -1
    */

    /* any optimization later

    */

    /* time complexity:
    space complexity:
    */
    public class MissingNumber
    {
        public int MissingNumberImpl(int[] nums)
        {
            int range = nums.Length;

            for(int i = 0; i <= range; i++)
            {
                for(int j = 0; j < nums.Length; j++)
                {
                    if(i == nums[j])
                    {
                        break;
                    }    
                }
              
            }

            return -1;
        }
    }
}