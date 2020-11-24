using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;


namespace labwork2
{
    public class V2DataCollection : V2Data
    {
        public List<DataItem> Values_field { get; set; }
        private static readonly Random Rand = new Random(42);

        public V2DataCollection(double freq_field, string description) : base(freq_field, description)
        {
            Values_field = new List<DataItem>();
        }

        public void InitRandom(int nItems,
                               float xmax,
                               float ymax,
                               double minValue,
                               double maxValue)
        {
            for (int i = 0; i < nItems; ++i) {
                DataItem val_field = new DataItem(new Complex(Rand.NextDouble() * (maxValue - minValue),
                                                              Rand.NextDouble() * (maxValue - minValue)),
                                                   new Vector2((float)(Rand.NextDouble() * xmax),
                                                               (float)(Rand.NextDouble() * ymax)));
                Values_field.Add(val_field);
            }
        }

        public override Complex[] NearAverage(float eps)
        {
            double real_mean_val = 0.0;
            foreach (DataItem val in Values_field) {
                real_mean_val += val.Value_field.Real;
            }
            real_mean_val /= Values_field.Count;

            return (from val in Values_field
                    where Math.Abs(val.Value_field.Real - real_mean_val) < eps
                    select val.Value_field).ToArray();
        }

        public override string ToString() => $"Type: V2DataCollection\n{base.ToString()}\nValues count: {Values_field.Count}\n";
        public override string ToLongString()
        {
            string str = ToString();
            foreach (DataItem val in Values_field) {
                str += val;
            }
            return str;
        }
    }
}
