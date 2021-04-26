using System.Collections.Generic;

namespace Lab10
{
    class SortOddEvenNumber
    {
        public static List<int> SortThings(List<int> seqToSort)
        {
            var Sorted = new List<int>(seqToSort);


            if (!isOddSrquence(Sorted))
                Sorted.Sort((a, b) => a.CompareTo(b));
            else
                Sorted.Sort((a, b) => b.CompareTo(a));

            return Sorted;
        }
        static bool isOddSrquence(List<int> seq)
        {
            int oddCount = 0;
            int evenCount = 0;
            foreach (var val in seq)
            {
                if (val % 2 != 0)
                    oddCount++;
                else
                    evenCount++;
            }
            return oddCount > evenCount;
        }
    }
}