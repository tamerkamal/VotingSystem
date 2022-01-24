using System;
using System.Collections.Generic;
using System.Text;

namespace SandBox.Services
{
    public class CounterService
    {
        public  float CalculatePercentageWith2DecimalPoints(int counter, int totalCounts)
        {
            float percentage = ((float)counter / totalCounts) * 100;

            return (float)Math.Round(percentage, 2);
        }
    }
}
