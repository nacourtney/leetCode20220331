using System;

/*
  We are playing the Guess Game. The game is as follows:

  I pick a number from 1 to n. You have to guess which number I picked.

  Every time you guess wrong, I will tell you whether the number I picked is higher or lower than your guess.

  You call a pre-defined API int guess(int num), which returns three possible results:

 -1: Your guess is higher than the number I picked (i.e. num > pick).
  1: Your guess is lower than the number I picked (i.e. num < pick).
  0: your guess is equal to the number I picked (i.e. num == pick).
  Return the number that I picked.

*/

/*
  Forward declaration of guess API.
  @param  num   your guess
  @return 	     -1 if num is higher than the picked number
 			      1 if num is lower than the picked number
                otherwise return 0
  int guess(int num);
 */

namespace GuessNumberHigherOrLower_lc_374
{
    
    class Solution : GuessNumber
    {
        public int pick = 6;
        static void Main(string[] args)
        {
            int n = 10;
            int test1 = GuessNumber(n);
            
        }

        public static int GuessNumber(int n)
        {
            GuessGame newGame = new GuessGame(pick);

            int guess = guess()
            

            return 1;
        }
    }

    class GuessGame
    {
        private int pick;

        public GuessGame(int pick)
        {
            this.pick = pick;
        }

        public int guess(int num)
        {
            if(num > pick)
            {
                return -1;
            } else if (num < pick)
            {
                return 1;
            }
            return 0;
        }

    }
}
