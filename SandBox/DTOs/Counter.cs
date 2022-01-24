using System;
using System.Collections.Generic;
using System.Text;

namespace SandBox.DTOs
{
    public class Counter
    {

        #region Fields

        private readonly string counterName;
        private readonly int initialCount;

        #endregion

        #region Properties

        public int counterValue;

        #endregion

        #region contructor

        public Counter(string counterName, int initialCount)
        {
            this.counterName = counterName;
            this.initialCount = initialCount;

            this.counterValue = initialCount;
        }

        #endregion
    }
}
