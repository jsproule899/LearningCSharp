using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Algorithims
{
    class Algorithims
    {
        public static void BubbleSort(int[] nums)
        {
            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] < nums[i - 1])
                    {
                        int temp = nums[i - 1];
                        nums[i - 1] = nums[i];
                        nums[i] = temp;
                        swapped = true;
                    }

                }
            }
        }

    
    }
}
