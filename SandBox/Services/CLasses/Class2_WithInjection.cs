using SandBox.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SandBox.Services
{
    #region Main Class
    public class Class2_WithInjection
    {
        private readonly IClass1 class1;

        public Class2_WithInjection(IClass1 class1)
        {
            this.class1 = class1;
        }

        public int Adder(int x, int y)
        {
            int result = class1.Add(x, y);
            //int result = x + y;

            Outer(x, y);

            return result;
        }

        public void Outer(int x, int y) => class1.Out(x, y);
    }

    #endregion
}
