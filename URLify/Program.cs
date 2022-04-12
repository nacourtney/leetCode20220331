using System;
using System.Text;

/*
 * Write a method to replace all spaces in a string with '%20'. You may assume that the string has sufficient space at the end to hold the additional characters, and that you are given the "true" length of the strong.
 * 
 * ---Note: If implementing in Java, please use a character array so that you can perform operations in place
 * 
 */

namespace URLify
{
    class Program
    {
        static void Main(string[] args)
        {
            string test1 = "Mr. John Smith";
            Console.WriteLine("Results: " + QuickURLify(test1));
        }

        public static string QuickURLify(string value)
        {
            // Create a string builder to add each character
            StringBuilder results = new StringBuilder();            

            for(int i = 0; i < value.Length; i++)
            {
                // Replace the empty spaces with %20
                if(value[i].ToString() == " ")
                {
                    results.Append("%20");
                } else
                {
                    results.Append(value[i]);
                }
            }            

            return results.ToString();
        }       

    }
}
