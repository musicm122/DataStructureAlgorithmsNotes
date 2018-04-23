using System.Linq;

namespace TestRunner
{
    public static class Sorts
    {
        public static int[] QuickSort(int[] items)
        {
            if (items.Length < 2)
            {
                return items;
            }
            else
            {
                var pivot = items[0];
                var less = items.Where(i => i < pivot);
                less.Append(pivot);
                var greater = items.Where(i => i > pivot);

                return QuickSort(less.Concat(greater).ToArray());
            }
        }

    }
}