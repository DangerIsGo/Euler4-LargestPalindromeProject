using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LargestPalindromeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;

            for (int i= 999; i>99; i--)
                for (int j = 999; j > 99; j--)
                {
                    if (IsPalindrome(i*j))
                    {
                        Console.WriteLine("{0} and {1} is {2}", i, j, i * j);
                        if (max < i * j)
                            max = i * j;
                    }
                }

            Console.WriteLine("Largest palindrome product is {0}", max);
            Console.ReadLine();
        }

        private static bool IsPalindrome(int i)
        {
            char[] foo = i.ToString().ToCharArray();

            if (foo.Length % 2 != 0)
                return false;

            for (int j = 0; j < foo.Length/2; j++)
            {
                if (foo[j] != foo[foo.Length - 1 - j])
                    return false;
            }

            return true;
        }
    }
}
