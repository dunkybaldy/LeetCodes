using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public static class SingleNumberThree
    {
        public static int[] Solve(int[] numbers)
        {
            var singles = numbers.ToList();

            var alreadyCheckedAndRemoved = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Count(x => x == numbers[i]) > 1 &&
                    !alreadyCheckedAndRemoved.Any(x => x == numbers[i]))
                {
                    alreadyCheckedAndRemoved.Add(numbers[i]);
                    singles.RemoveAll(x => x == numbers[i]);
                }
            }
            Console.WriteLine(alreadyCheckedAndRemoved.Count);
            return singles.ToArray();
        }
    }
}
