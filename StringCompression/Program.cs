using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

/*
 * String Compression:
 * Implement a method to perform basic string compression using the counts of repeated characters. For example, the string aabcccccaa would become a2b1c5a3. If the "compressed" string would not becomes smaller than the original string, your method should return the original string. You can assume the string has only uppercase and lowercase letters.
 * 
 */

namespace StringCompression
{
    class Program
    {
        static void Main(string[] args)
        {
            //string test1 = "abcdef";
            //Console.WriteLine("Results: " + compressString(test1));

            string test2 = "abbb";
            Console.WriteLine("Results: " + compressString(test2));
        }

        public static string compressString(string value)
        {
            
            StringBuilder compressedString = new StringBuilder();
            int occurenceCounter = 0;
            string currentLetter = "";

            for(int i = 0; i < value.Length; i++)
            {                

                if (value[i].ToString() != currentLetter)
                {
                    compressedString.Append(value[i]);
                    currentLetter = value[i].ToString();                  
                    
                } else
                {                    
                    compressedString.Append(occurenceCounter);
                    occurenceCounter = 0;
                }
                

            }

            return compressedString.ToString();
        }
    }
}
