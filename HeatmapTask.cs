using System;

namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
            double[,] matrix = new double[30, 12];
            foreach(var e in names)
            {
                if (e.BirthDate.Day!=1)
                    matrix[e.BirthDate.Day-2, e.BirthDate.Month-1]++;
            }


            string[] days = new string[30];
            for (int i = 0; i < days.Length; i++)
                days[i] = (2 + i).ToString();

            string[] months = new string[12];
            for (int i = 0; i < months.Length; i++)
                months[i] = (1+i).ToString();

            return new HeatmapData(
                "Пример карты интенсивностей",
                matrix, 
                days, 
                months);
        }
    }
}
