using SandBox.DTOs;
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

            int totalCounts = yesCounter.counterValue + noCounter.counterValue + mayBeCounter.counterValue;

            float yesPercentage = counterService.CalculatePercentageWith2DecimalPoints(yesCounter.counterValue, totalCounts);
            float noPercentage = counterService.CalculatePercentageWith2DecimalPoints(noCounter.counterValue, totalCounts);
            float mayBePercentage = counterService.CalculatePercentageWith2DecimalPoints(mayBeCounter.counterValue, totalCounts);

            Console.WriteLine($"Yes counts: {yesCounter}, No counts: {noCounter}, MayBe counts: {mayBeCounter}\n");
            Console.WriteLine($"Yes percentage: {yesPercentage}, No percentage: {noPercentage}, MayBe percentage: {mayBePercentage}\n");

            if (yesCounter.counterValue > noCounter.counterValue && yesCounter.counterValue > mayBeCounter.counterValue)
            {
                Console.WriteLine($"Yes won");
            }
            else if (noCounter.counterValue > yesCounter.counterValue && noCounter.counterValue > mayBeCounter.counterValue)
            {
                Console.WriteLine($"No won");
            }
            else if (mayBeCounter.counterValue > yesCounter.counterValue && mayBeCounter.counterValue > noCounter.counterValue)
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
