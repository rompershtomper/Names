using System;
using System.Linq;

namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {
            double[] counter = new double[31];
            foreach (var e in names)
            {
                if (e.Name==name && e.BirthDate.Day!=1)
                    counter[e.BirthDate.Day-1]++;
            }

            string[] lable = new string[31];
            for (int i = 0; i < lable.Length; i++)
                lable[i] = (i+1).ToString();

            return new HistogramData(
                string.Format("Рождаемость людей с именем '{0}'", name),
                lable, 
                counter);
        }
    }
}