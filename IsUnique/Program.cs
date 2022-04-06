using System;
using System.Collections;
/*
* Implementan algorithm to determine if a string has all unique characters. 
* What if you cannot use additional data structures?
*/

namespace IsUnique
{
    class Program
    {
        static void Main(string[] args)
        {
            string test1 = "hello"; // Should return false
            string test2 = "world"; // Should return true
            Console.WriteLine("All characters in hello unique: " + theLongWay(test1));
            Console.WriteLine("All characters in world unique: " + theLongWay(test2));

            string test3 = "hello"; // Should return false
            string test4 = "world"; // Should return true
            Console.WriteLine("All characters in hello unique: " + theLongWay(test3));
            Console.WriteLine("All characters in world unique: " + theLongWay(test4));
        }

        public static bool theLongWay(string value)
        {
            value = value.ToLower();

            for(int i = 0; i < value.Length; i++)
            {
                for(int j = i + 1; j < value.Length; j++)
                {
                    if(value[i] == value[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool theShortWay(string value)
        {
            value = value.ToLower();

            Hashtable newHashMap = new Hashtable();

            foreach(var letter in value)
            {
                if (newHashMap.ContainsKey(letter))
                {
                    return false;
                } else
                {
                    newHashMap.Add(letter, 0);
                }
            }
            return true;
        }
    }
}
