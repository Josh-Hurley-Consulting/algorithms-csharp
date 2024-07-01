using Xunit;
using AlgorithmClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmClassLibrary.Tests
{
    public class PalindromeTests
    {
        [Fact()]
        public void IsPalindrome_ShouldReturnTrue_OddNumberOfChars()
        {
            var word = "racecar";
            var isPalindrome = Palindrome.IsPalindrome(word);

            Assert.True(isPalindrome);
        }

        [Fact()]
        public void IsPalindrome_ShouldReturnTrue_EvenNumberOfChars()
        {
            var word = "abba";
            var isPalindrome = Palindrome.IsPalindrome(word);

            Assert.True(isPalindrome);
        }

        [Fact()]
        public void IsPalindrome_ShouldReturnFalse()
        {
            var word = "josh";
            var isPalindrome = Palindrome.IsPalindrome(word);

            Assert.False(isPalindrome);
        }
    }
}