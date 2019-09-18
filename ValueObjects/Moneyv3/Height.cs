using System;
using System.Collections.Generic;
using System.Text;

namespace ValueObjects.Moneyv3
{
    public enum MeasurmentUnit
    {
        Metres,
        Feet
    }
    public class Height
    {
        public Height(int size, MeasurmentUnit unit)
        {
            this.Size = size;
            this.Unit = unit;
        }
        public int Size { get; private set; }
        public MeasurmentUnit Unit { get; private set; }
        // ..
        public static Height FromFeet(int feet)
        {
            return new Height(feet, MeasurmentUnit.Feet);
        }
        public static Height FromMetres(int metres)
        {
            return new Height(metres, MeasurmentUnit.Metres);
        }
    }
}
