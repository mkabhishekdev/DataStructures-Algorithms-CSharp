using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace InterviewLabCodeRepo.Interview
{
    /* Referred approach
    1. use a Dictionary to store the num from nums as key and initially set the value to false for all
    2. idea is to keep iterating over the [], and if you satisfy the logic nextnum = num+1
       keep updating the value to true, it means you have already gone through this element
    3. add suitable while conditions and math function to get the count of the longestsequence
    */
    /* any optimization later

    */
    /* time complexity: O(n)
    space complexity: O(n)
    */
    public class LongestConsecutiveSequence
    {
        public int LongestConsecutiveSequenceImpl(int[] nums)
        {
            int longestLength = 0;

            Dictionary<int,bool> checkMap = new Dictionary<int, bool>();
            foreach(int num in nums)
            {
                checkMap[num] = false;
            }
            
            // to check in forward direction
            foreach(int num in nums)
            {
                int currentLength = 1;
                int nextNum = num + 1;
                
                while(checkMap.ContainsKey(num) && checkMap[num] == false)
                {
                    currentLength++;
                    checkMap[num] = true;
                    nextNum++;
                }

                // to check in reverse direction
                int prevNum = num - 1;
                while(checkMap.ContainsKey(prevNum) && checkMap[prevNum] == false)
                {
                    currentLength++;
                    checkMap[num] = true;
                    prevNum--;
                }

                longestLength = Math.Max(longestLength, currentLength);
            }

            return longestLength;
        }
        
    }
}

/* Failed approach and why?()
  1. use a Hashset to remove duplicates from the array
    2. sort the array using inbuilt method
    3. iterate through the updated[], using a track-counter -> count the 
       flow of the [] when it is in a sequence
    4. return the count
 public int LongestConsecutiveSequenceImpl(int[] nums)
        {
            if(nums.Length == 0)
            {
                return 0;
            }

            Array.Sort(nums);
            HashSet<int> hs = new HashSet<int>(nums);

            int[] updatedInput = hs.ToArray();

            for(int i = 0; i < updatedInput.Length; i++)
            {
                
            }
            

        }
*/