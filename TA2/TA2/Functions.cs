using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public enum SortOrder { Ascending, Descending };


    public static class Functions
    {
        public static bool IsSorted(int[] array, SortOrder order)
        {
            if (array == null)
                throw new ArgumentNullException();
            else
            {
                if (order == SortOrder.Ascending)
                {
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        if (array[i] > array[i + 1])
                            return false;
                    }
                    return true;
                }
                else
                {
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        if (array[i] < array[i + 1])
                            return false;
                    }
                    return true;
                }
            }
        }

        //public static bool IsSorted(int[] array, SortOrder order)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
