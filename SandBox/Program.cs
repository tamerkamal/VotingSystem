using SandBox.Entities;
using SandBox.Services;
using System;

namespace SandBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int yesCounter = 3,
            //    noCounter = 6,
            //    mayBeCounter = 2;

            Counter yesCounter = new Counter("Yes Counter", 3);
            Counter noCounter = new Counter("No Counter", 6);
            Counter mayBeCounter = new Counter("mayBeCounter Counter", 2);

            CounterService  counterService = new CounterService();  

            int totalCounts = yesCounter.Value + noCounter.Value + mayBeCounter.Value;

            float yesPercentage = counterService.CalculatePercentageWith2DecimalPoints(yesCounter.Value, totalCounts);
            float noPercentage = counterService.CalculatePercentageWith2DecimalPoints(noCounter.Value, totalCounts);
            float mayBePercentage = counterService.CalculatePercentageWith2DecimalPoints(mayBeCounter.Value, totalCounts);

            Console.WriteLine($"Yes counts: {yesCounter}, No counts: {noCounter}, MayBe counts: {mayBeCounter}\n");
            Console.WriteLine($"Yes percentage: {yesPercentage}, No percentage: {noPercentage}, MayBe percentage: {mayBePercentage}\n");

            if (yesCounter.Value > noCounter.Value && yesCounter.Value > mayBeCounter.Value)
            {
                Console.WriteLine($"Yes won");
            }
            else if (noCounter.Value > yesCounter.Value && noCounter.Value > mayBeCounter.Value)
            {
                Console.WriteLine($"No won");
            }
            else if (mayBeCounter.Value > yesCounter.Value && mayBeCounter.Value > noCounter.Value)
            {
                Console.WriteLine($"MayBe won");
            }
            else
            {
                Console.WriteLine($"Drawn");
            }
        }    
    }  
}
