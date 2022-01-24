using SandBox.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SandBox.Services.Classes
{   
        /// <summary>
    /// Class to be tested
    /// </summary>
    public class Class1 : IClass1
    {
        public int Add(int a, int b) => a + b;

        public void Out(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
