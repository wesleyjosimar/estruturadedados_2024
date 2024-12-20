using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobbleSort
{
    public static class DobbleSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for(int i = 0; i < array.Length -1; i++)
            {
                for (int j = 0;  j < array.Length -1; j++)
                {
                    if(array[j].CompareTo(array[j+1]) > 0)
                    {
                        Swap(array,j, j+1);
                    }
                }
            }
        }
        public static void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}

