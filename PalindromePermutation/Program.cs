using System;

/*
 * Palindrome Permuation:
 * Given a string, wrtie a function to check if it is a permutation of a palindrome. A palindrome is a word or phrase that is the same forwards and backwards. A permutation is a rearrangement of letters. The palindrome does not need to be limited to just dictionary words. You can ignore casing and non-letter characters
 * 
 */


namespace PalindromePermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            string palindromeTest1 = "abcdefgfedcba";
            string test1 = "aabbccddeeffg";

            Console.WriteLine("Results: " + palindromeChecker(palindromeTest1, test1));
        }

        public static bool palindromeChecker(string palindrome, string possiblePermutation)
        {
            // Find the length  with the empty spaces removed:
            int palindromeTrueLength = getTrueLength(palindrome);
            int possiblePalindromTrueLength = getTrueLength(possiblePermutation);
            
            // Ensure the true length is equal
            if(palindromeTrueLength != possiblePalindromTrueLength)
            {
                return false;
            }

            // Sort both parameters
            string sortedPalindrome = stringSort(palindrome);
            string sortedPossible = stringSort(possiblePermutation);

            // Compare character by character
            for(int i = 0; i < palindrome.Length; i++)
            {
                // If a mismatch is identified return false
                if(sortedPalindrome[i] != sortedPossible[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static int getTrueLength(string value)
        {
            int lengthCounter = 0;

            if(value.Length <= 1)
            {
                return value.Length;
            }

            // Do not count the empty spaces
            for(int i = 0; i < value.Length; i++)
            {
                if(value[i].ToString() != " ")
                {
                    lengthCounter++;
                }
            }

            return lengthCounter;
        }

        public static string stringSort(string value)
        {
            char[] characters = value.ToCharArray();

            Array.Sort(characters);

            return new string(characters);
        }
    }
}
