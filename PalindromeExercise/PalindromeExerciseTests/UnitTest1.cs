using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hannah", true)]
        [InlineData("hector", false)]
        public void IsPalindromeTest(string someWord, bool expected)  
        {
            //Arrange
            var instance = new WordSmith();

            //Act
            var actual = instance.IsPalindrome(someWord);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
