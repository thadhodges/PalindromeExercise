using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("baker", false)]
        [InlineData("QWERTREWQ", true)]

        public void IsAPalindrome(string word, bool expected)
        {
            WordSmith challenger = new WordSmith();
            bool actual = challenger.IsAPalindrome(word);
            Assert.Equal(actual, expected);
        }
    }
}
