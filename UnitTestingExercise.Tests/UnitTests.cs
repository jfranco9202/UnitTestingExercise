using System;
using System.Collections.Generic;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        private IEnumerable<object> expected;

        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(5, 5, 5, 15)]

        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5, 5, 0)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test1 = new UnitTestMethods();

            //Act
            var actual = test1.Subtract(minuend, subtrhend);


            //Assert
            Assert.Equal(expected, actual);

        }
        [Theory]
        [InlineData(5,5, 25)]
        [InlineData(2, 4, 8)]

        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test2 = new UnitTestMethods();

            //Act
            var actual = test2.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(25,5,5)]
        [InlineData(5,5, 1)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test3 = new UnitTestMethods();

            //Act
            var actual = test3.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("no",true)]
        [InlineData("yes",false)]
        
        public void CanPenguinsFly(string word,bool expected)
        {
            //Arrange
            var test4 = new UnitTestMethods();

            //Act
            var actual = test4.CanPenguinsFly(word);

            //Assert
            Assert.Equal(expected,actual);

        }

        [Theory]
        [InlineData("no",false)]
        [InlineData("yes",true)]
        public void CanCatsSwim(string word, bool expected)
        {
            //Arrange
            var test5 = new UnitTestMethods();

            //Act
            var actual = test5.CanCatsSwim(word);

            //Assert
            Assert.Equal(expected,actual);
        }
    }
}
