using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    public static partial class Lesson7
    {
        public static int FindMax(params int[] nums) =>
            Lesson5.Lesson5.FoldArrayValue(nums, nums[0], (element, acc) => element > acc ? element : acc);
    }
}
