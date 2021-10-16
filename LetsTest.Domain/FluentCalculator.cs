using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsTest.Domain
{
    public class FluentCalculator
    {
        public double Result { get; private set; }

        public FluentCalculator()
        {
            Result = 0;
        }

        public FluentCalculator Plus(double value)
        {
            Result += value;
            return this; //como eu retorno como this, posso chamar N vez por fluidez 
        }

        public FluentCalculator Minus(double value)
        {
            if(value < 0)
            {
                throw new ArgumentException($"negative numbers not allowed", nameof(value));
            }
            Result -= value;
            return this;
        }
        public FluentCalculator MultiplyBy(double value)
        {
            Result *= value;
            return this;
        }

        public FluentCalculator DivideBy(double value)
        {
            Result /= value;
            return this;
        }

        public FluentCalculator Pow(double value)
        {
            Result = Math.Pow(Result, value);
            return this;
        }

        public FluentCalculator Sqrt()
        {
            Result = Math.Sqrt(Result);
            return this;
        }
    }
}
