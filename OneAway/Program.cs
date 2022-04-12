using System;

/*
 * One Away:
 * There are three types of edits that can be oerformed on strings: inserts a character, remove a chracter, or replace a character. Given two strings, write a function to check if they are one edit (or two edits) away
 * 
 */

namespace OneAway
{
    class Program
    {
        static void Main(string[] args)
        {
            string correctWord = "Helllo";
            string incorrectWord = "Helo";

            Console.WriteLine("1. Results " + determineOneAway(correctWord, incorrectWord));

            string correctWord1 = "Hello";
            string incorrectWord1 = "Hemmo";

            Console.WriteLine("2. Results " + determineOneAway(correctWord1, incorrectWord1));

            string correctWord2 = "Hello";
            string incorrectWord2 = "Hennllo";

            Console.WriteLine("3. Results " + determineOneAway(correctWord2, incorrectWord2));


        }

        public static bool determineOneAway(string correctWord, string incorrectWord)
        {

            if (correctWord.Equals(incorrectWord))
            {
                return false;
            }
            
            if(insertACharacter(correctWord, incorrectWord))
            {
                Console.WriteLine("Insert a character. ");
                return true;
            }

            if(removeACharacter(correctWord, incorrectWord))
            {
                Console.WriteLine("Remove a character. ");
                return true;
            }

            if(replaceACharacter(correctWord, incorrectWord))
            {
                Console.WriteLine("Replace a character. ");
                return true;
            }

            return false;
        }

        public static bool replaceACharacter(string correctWord, string incorrectWord)
        {
            int problemCounter = 0;

            if(correctWord.Length != incorrectWord.Length)
            {
                return false;
            }

            for(int i = 0; i < correctWord.Length; i++)
            {
                if(correctWord[i] != incorrectWord[i])
                {
                    problemCounter++;
                }
            }

            if(problemCounter > 1)
            {
                return false;
            }

            return true;
        }

        public static bool insertACharacter(string correctWord, string incorrectWord)
        {
            int nextPointer = 0;
            
            string shorter = "";
            string longer = "";

            if(Math.Abs(correctWord.Length - incorrectWord.Length) != 1)
            {
                return false;
            }

            // Determine which has a shorter length
            if(correctWord.Length > incorrectWord.Length)
            {
                longer = correctWord;
                shorter = incorrectWord;
            } else
            {
                longer = incorrectWord;
                shorter = correctWord;
            }
           

            for(int i = 0; i < longer.Length - 2; i++)
            {
                // If the letters are not the same, compare the next character of shorter
                if(longer[i] != shorter[i])
                {
                    nextPointer = i + 1;

                        if (longer[i] != shorter[nextPointer])
                        {
                            return false;
                        }                    
                }

                
            }

            return true;
        }

        public static bool removeACharacter(string correctWord, string incorrectWord)
        {
            int nextPointer = 0;

            string shorter = "";
            string longer = "";

            if (Math.Abs(correctWord.Length - incorrectWord.Length) != 1)
            {
                return false;
            }

            // Determine which has a shorter length
            if (correctWord.Length > incorrectWord.Length)
            {
                longer = correctWord;
                shorter = incorrectWord;
            }
            else
            {
                longer = incorrectWord;
                shorter = correctWord;
            }

            for(int i = 0; i < longer.Length - 2; i++)
            {
                if(longer[i] != shorter[i])
                {
                    nextPointer = i + 1;

                    if(longer[nextPointer] != shorter[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
