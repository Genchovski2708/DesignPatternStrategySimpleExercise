using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPaternStrategy_Exercise
{
    internal interface ISortingStrategy
    {
        public int[] Sort(int[] array);
    }
}
