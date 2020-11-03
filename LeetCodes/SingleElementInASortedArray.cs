using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public static class SingleElementInASortedArray
    {
        // Not fast enough
        public static int Solve(int[] nums)
        {
            var maxLength = nums.Length / 5;

            var firstArray = nums.Take(nums.Length / 2).ToArray();
            var secondArray = nums.Skip(nums.Length / 2).ToArray();

            return 0;
        }

        public static List<int[]> SplitArray(int maxLength, int[] array)
        {
            var returnMe = new List<int[]>();

            var a = array.Take(array.Length / 2).ToArray();
            var b = array.Skip(array.Length / 2).ToArray();


            if (a.Length > b.Length)
                // a has more
            {
                if (a.Length > maxLength)
                {
                    var arrs = SplitArray(maxLength, a);
                    returnMe.AddRange(arrs);
                }
            }
        }

        public static int TooSlow(int[] nums)
        {
            var list = nums.ToList();

            for (var i = 0; i < list.Count; i++)
            {
                var selection = list.Where(x => x == list[i]);
                if (selection.Count() == 1)
                    return list[i];
            }

            return 0;
        }
    }
}
