using System;
using System.Collections.Generic;

namespace ProductionCode
{
    public class ArrayProcessor
    {
        public int[] SortAndFilter(int[] array)
        {
            List<int> arrList = new List<int>(array);
            arrList.Sort();
            for(int i = 0; i < arrList.Count - 1; ++i)
                if (arrList[i] == arrList[i + 1])
                    arrList.RemoveAt(i);
            return arrList.ToArray();
        }
    }
}
