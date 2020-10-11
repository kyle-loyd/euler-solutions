using System;

// A palindromic number reads the same both ways. 
// The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
// Find the largest palindrome made from the product of two 3-digit numbers.

namespace euler_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = FindLargestPalindrome();
            Console.WriteLine($"Answer: {answer}");
        }

        static int FindLargestPalindrome() {
            var max = 999;
            var sampleSet = 100;
            var nextTier = max - sampleSet;
            while (true) {
                if (max == nextTier) {
                    nextTier -= sampleSet;
                }
                for (var current = max; current <= max; current--) {
                    if (current == nextTier) {
                        break;
                    }
                    var product = current * max;
                    if (product == ReverseNumber(product)) {
                        return product;
                    }
                }
                max -= 1;
            }
        }

        static int ReverseNumber(int number) {
            var numString = number.ToString();
            var array = numString.ToCharArray();
            Array.Reverse(array);
            var reverseString = new string(array);
            return int.Parse(reverseString);
        }
    }
}
