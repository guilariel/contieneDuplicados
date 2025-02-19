using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace contieneDuplicados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [1, 2, 3, 1];

            if (SeRepite(nums)) Console.WriteLine("true"); else Console.WriteLine("false"); ;
        }

        public static bool SeRepite(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                set.Add(nums[i]);
                if(set.Count - 1 != i)
                {
                    Console.WriteLine(set.Count);
                    Console.WriteLine(i);
                    return true;
                }
            }
            return false;
        }
    }
}
