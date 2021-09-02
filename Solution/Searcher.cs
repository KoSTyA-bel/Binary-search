using System;
using System.Collections.Generic;

namespace Solution
{
    public static class Searcher
    {
        public static int Search<T>(T[] data, T elementToSearch)
        {
            if (data is null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            int left = 0;
            int right = data.Length - 1;
            var comparer = Comparer<T>.Default;

            while (left <= right)
            {
                var middle = (left + right) / 2;
                var number = comparer.Compare(data[middle], elementToSearch);

                if (number == 0)
                {
                    return middle;
                }
                else if (number > 0)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return -1;
        }
    }
}
