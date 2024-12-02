using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] ans = new int[] { 0, 0 };
            int a = 0, b = 0;
            for (int i = 0; i < nums.Count() - 1; i++)
            {
                for (int j = i + 1; j < nums.Count() - 1; i++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        ans[0] = i;
                        ans[1] = j;
                        a = 1;
                        break;
                    }
                    if (a > 0)
                        break;

                }

            }
            ans[0] = a;
            ans[1] = b;
            return ans;


        }

        public static void Main()
        {
            int[] ans = TwoSum(new int[] { 3, 2, 3 }, 6);
            Console.WriteLine(ans[0]+""+ans[1]);
            Console.ReadKey();
        }
    }
}

