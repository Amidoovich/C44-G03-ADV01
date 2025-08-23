using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_ADV01
{
    internal class Range<T> where T : INumber<T>
    {
        public T Max { get; }
        public T Min { get; }

        public Range(T max,T min)
        {
            Max = max;
            Min = min;

        }

        public bool IsInRange(T value)
        { 
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        public T length()
        { 
            return  Max - Min;
        }
    }
}