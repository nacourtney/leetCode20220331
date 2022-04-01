﻿using System;

/*
 
This is an interactive problem.

You have a sorted array of unique elements and an unknown size. 
You do not have an access to the array but you can use the ArrayReader 
interface to access it. You can call ArrayReader.get(i) that:

returns the value at the ith index (0-indexed) of the secret array (i.e., secret[i]), or
returns 231 - 1 if the i is out of the boundary of the array.
You are also given an integer target.

Return the index k of the hidden array where secret[k] == target or return -1 otherwise.

You must write an algorithm with O(log n) runtime complexity.

*/
//---------------------------------------------------------------------------------------
/*
 
This is ArrayReader's API interface.
You should not implement it, or speculate about its implementation

 class ArrayReader 
 {
     public int Get(int index) {}
 }

*/

namespace SearchInASortedArrayOfUnknownSize_lc_702
{
    class SearchInSortedArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
