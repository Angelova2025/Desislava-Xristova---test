using System.Globalization;

namespace ConsoleApp1
{

    internal class Program
    {
        static void Main(string[] args)
        {
          

            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int theBigest = 0;
            int sum = 0;
            int count = 0;
            int element = 0;
            int maxCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > theBigest)
                {
                    theBigest = nums[i];
                }
                sum += nums[i];

            }
            for (int i = 0; i < nums.Length; i++)
            {
                count = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
                    }
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    element = nums[i];
                }
            }
         
            Console.WriteLine($"Сума на елементите{string.Join(" ", sum)}");
            Console.WriteLine($"Най-голям елемент: {string.Join(" ", theBigest)}");
            Console.WriteLine($"Числото {string.Join(" ", element)} се среща най-много пъти");
     
       
        }
    }

}