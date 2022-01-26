using System;
using System.Collections.Generic;
using System.Text;

namespace SandBox.Entities
{
    public class Counter
    {
        #region Constructor

        public Counter(string name, int initialValue)
        {
            this.Name = $"{name} Counter";

            if (initialValue < 0)
            {
                this.InitialValue = 0;
            }
            else
            {
                this.InitialValue = initialValue;
            }

            this.Value = this.InitialValue;
        }

        #endregion

        #region Properties

        public string Name { get; }
        public int InitialValue { get; }
        public int Value { get; set; }    

        #endregion
    }
}

