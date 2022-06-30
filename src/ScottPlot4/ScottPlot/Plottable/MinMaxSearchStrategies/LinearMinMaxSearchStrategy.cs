using System;
using System.Numerics;

namespace ScottPlot.MinMaxSearchStrategies
{
    public class LinearMinMaxSearchStrategy<T> : IMinMaxSearchStrategy<T>
        where T : INumber<T>, IMinMaxValue<T>
    {
        private T[] sourceArray;
        public virtual T[] SourceArray
        {
            get => sourceArray;
            set => sourceArray = value;
        }

        public LinearMinMaxSearchStrategy()
        {
        }

        public virtual void MinMaxRangeQuery(int l, int r, out double lowestValue, out double highestValue)
        {
            T lowestValueT = sourceArray[l];
            T highestValueT = sourceArray[l];
            for (int i = l; i <= r; i++)
            {
                if (sourceArray[i] < lowestValueT)
                    lowestValueT = sourceArray[i];
                if (sourceArray[i] > highestValueT)
                    highestValueT = sourceArray[i];
            }
            lowestValue = Convert.ToDouble(lowestValueT);
            highestValue = Convert.ToDouble(highestValueT);
        }

        public virtual double SourceElement(int index)
        {
            return Convert.ToDouble(sourceArray[index]);
        }

        public void updateElement(int index, T newValue)
        {
            sourceArray[index] = newValue;
        }

        public void updateRange(int from, int to, T[] newData, int fromData = 0)
        {
            for (int i = from; i < to; i++)
            {
                sourceArray[i] = newData[i - from + fromData];
            }
        }
    }
}
