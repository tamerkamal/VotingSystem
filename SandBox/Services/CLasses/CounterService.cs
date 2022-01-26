using System;
using System.Collections.Generic;
using System.Text;

namespace SandBox.Services
{
    public class CounterService
    {
        public float CalculatePercentageWith2DecimalPoints(int counter, int totalCounts)
        {
            float percentage = ((float)counter / totalCounts) * 100;

            return (float)Math.Round(percentage, 2);
        }

        public float GetCounterVotesPercentage(int counterValue, int totalVotes)
        {
            var result = ((float)counterValue / totalVotes) * 100;

            if (result < 0) { throw new ArgumentException(nameof(counterValue)); }

            return (float)Math.Round(result, 2);
        }
    }
}

