using SandBox.Services.Classes;
using System;
using System.Collections.Generic;
using Xunit;

namespace SandBox.Tests.UnitTests
{     
    public class Service1_Tests
    {
        [Fact] // Static values, no parameters
        public void Add_StaticTest()
        {
            // Assign
            int result = new Service1().Add(2, 3);

            // Assert
            Assert.Equal(6, result);
        }     

        [Fact] // Static values, no parameters
        public void ContainsCheck()
        {
            // Assign
            List<int> list = new List<int> { 1, 4 };

            // Assert
            Assert.Contains(1, list);
        }

        [Theory] // Dynamic values, has Paramters
        [InlineData(2, 3, 5)] // subTest1
        [InlineData(2, 3, 7)] // subTest2
        public void Add_DynamicTest(int num1, int num2, int expected)
        {
            // Assign
            int result = new Service1().Add(num1, num2);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
