using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsPalindrome(string originalWord)
        {
            string reversedWord = string.Empty;

            for (int i = originalWord.Length-1; i >= 0; i--)
            {
                reversedWord += originalWord[i];

            }
            if(originalWord == reversedWord)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
