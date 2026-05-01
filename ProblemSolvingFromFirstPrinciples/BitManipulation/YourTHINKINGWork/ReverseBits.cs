using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewLabCodeRepo.Interview
{
    /* My Approach
    1. get the binary representation of n
    2. reverse it
    3. return the number representation of the reversed binary value
    */

    /* any optimization later

    */

    /* time complexity:
    space complexity:
    */
    public class ReverseBits
    {
        public int ReverseBitsImpl(int n)
        {
            int res = 0;

            for(int shift = 31; shift >= 0; shift--)
            {
                int bit = n & 1;
                res = res + (bit << shift);
                n = n >> 1;
            }
            
            return res;

        }
    }
}