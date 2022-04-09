using System;

/*
 * Given two strings, write a method to decide is one is a permuation of
 * the other.
 * 
 * Permutation: a way, especially one of several possible varitations, in
 * which a set or number of things can be ordered or arranged.
 * 
 */

namespace CheckPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            string test1a = "aba";
            string test2b = "baa";

            Console.WriteLine("Results: " + isPermutation(test1a, test2b));

        }

        public static bool isPermutation(string value1, string value2)
        {
            // Ensure both strings are the same length
            if(value1.Length != value2.Length)
            {
                return false;
            }
                  
            // Permutations have all the same characters - sort both of the strings
            string sort1 = sort(value1).ToLower();
            string sort2 = sort(value2).ToLower();

            // Ensure each string is the same
            for(int i = 0; i < value1.Length; i++)
            {
                // If a character is not the same, it is not a permutation
                if(sort1[i] != sort2[i])
                {
                    return false;
                }
            }           

            return true;
        }

        public static string sort(string word)
        {
            char[] characters = word.ToCharArray();

            Array.Sort(characters);

            return new string(characters);
            
        }
    
    }
}
