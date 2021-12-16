using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {

        public bool IsAPalindrome(string word)
        {
            char[] chars = word.ToCharArray();
            Array.Reverse(chars);
            var reversed = new string(chars);
            
            if (reversed == word )
            {
                return true;
            }
            return false;
        }

    }
}
