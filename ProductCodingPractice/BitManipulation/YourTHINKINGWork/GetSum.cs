using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
APPROACH I CAME UP WITH:
Incorrect, look into the bit manipulation notes to clearly understand how logical 'addition' works

Time Complexity: O(w)
Space Complexity: O(1)
❓ Is Time Complexity O(n)?

Short answer:
👉 Not O(n) in the usual sense.

What does n even mean here?

There is no array, list, or input size growing with n.

Instead, the loop runs based on:

How many times carry propagates

That depends on:

The number of bits in the integers

✅ Correct Time Complexity
Time Complexity: O(w)

Where:

w = number of bits in the integer


For C# int:

w = 32


So practically:

O(32) → O(1)

Why?

Each loop moves the carry one bit left

Carry can only move at most w times

Once it exits the highest bit, it becomes zero

So:

The loop cannot run more than the number of bits

❌ Why saying O(n) is misleading

O(n) implies:

Input size grows

Work grows with input length

Here:

Integers are fixed-width

Work is bounded

Interviewers will ding this.

✅ Space Complexity

You said:

Space Complexity: O(1)


✔️ Correct

Why?

Uses a constant number of variables

No extra memory proportional to input
*/

namespace ProductCodingPractice.BitManipulation.YourTHINKINGWork
{
    public class GetSum
    {
        public int GetSumImpl(int a, int b)
        {

            while (b != 0)
            {
                int sum = a ^ b; // XOR operation which would not save carry
                int carry = (a & b) << 1; // carry, see fundamental notes to remember this

                a = sum;
                b = carry;
            }

            return a; 
        }
    }
}

 // If all test cases not clearing, PRACTICE DEBUGGING
/* FAILED APPROACH & WHY
1. Use the bit values of a and b
2. perform logical 'OR' operation on them and store in a result variable
3. return the result
*/ 