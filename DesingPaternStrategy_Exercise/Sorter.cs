using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPaternStrategy_Exercise
{
    internal class Sorter
    {
        ISortingStrategy SortingStrategy { get; set; }

        public Sorter(ISortingStrategy sortingAlgorithm)
        {
            SortingStrategy = sortingAlgorithm;
        }
        public void SetSortingStrategy(ISortingStrategy sortingAlgorithm)
        {
            SortingStrategy = sortingAlgorithm;
        }
        public int[] SortArray(int[] array)
        {
            return SortingStrategy.Sort(array);
        }
    }
}
