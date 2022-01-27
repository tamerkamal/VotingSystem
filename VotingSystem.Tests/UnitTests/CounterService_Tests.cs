using Polly;
using SandBox.Entities;
using SandBox.Services;
using System;
using Xunit;
using static Xunit.Assert;

namespace SandBox.Tests.UnitTests
{
    public class CounterService_Tests
    {
        /// <summary>
        /// Validate the value "Counter" is part of its name
        /// </summary>
        [Fact] // Static values, no parameters
        public void ContainsCounterInItsName()
        {

            var counter = new Counter("Yes", 0);

            //Assert.Contains("Counter", counter.Name);
            // Assert removed because we are using static Xunit.Assert
            Contains("Counter", counter.Name);
        }

        [Fact]
        public void Counter_CheckInitialValueGreatherThanOrEqual0()
        {
            var counter = new Counter("Yes", -1);

            Assert.True(counter.InitialValue >= 0);

            //True(counter.InitialValue >= 0);

            //Assert.Throws<ArgumentException>();
        }


        //[Theory(Skip = "specific skip reason")]  Sktip this test case
        [Theory] // parameterized
        [InlineData(5, 10, 50)]
        [InlineData(1, 3, 33.33)]
        public void GetCounterVotesPercentage_ChechCounterVotesPercentageBasedOn2DecimalPoints(int counterValue, int totalVotes, float expectedPercentage)
        {
            var counter = new Counter("Yes", counterValue);

            var counterService = new CounterService();

            float actualPercentage = counterService.GetCounterVotesPercentage(counterValue, totalVotes);

            Assert.Equal(expectedPercentage, actualPercentage);
        }

        [Theory] // parameterized        
        [InlineData(-1, 2)]
        public void GetCounterVotesPercentage_ChechCounterVotesThrowsArgumentExceptionWhenNegativ(int counterValue, int totalVotes)
        {
            var counter = new Counter("Yes", counterValue);

            var counterService = new CounterService();

            if (counterValue < 0)
            {
                Throws<ArgumentException>(() => counterService.GetCounterVotesPercentage(counterValue, totalVotes));
            }
        }
    }
}
