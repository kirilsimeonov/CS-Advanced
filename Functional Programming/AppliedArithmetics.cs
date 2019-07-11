using System;
using System.Linq;

namespace Applied
{
    class Program
    {
        public delegate int[] ArrayManipulator(int[] nums);



        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();



            string input = Console.ReadLine();
            while (input != "end")
            {
                if (input == "add")
                {
                    numbers = Action(numbers, Add);
                }
                else if (input == "multiply")
                {
                    numbers = Action(numbers, Multiply);
                }
                else if (input == "subtract")
                {
                    numbers = Action(numbers, Substract);
                }
                else if (input == "print")
                {
                    Console.WriteLine(string.Join(' ', numbers));
                }
                input = Console.ReadLine();
            }
        }



        public static int[] Action(int[] nums, ArrayManipulator opr)
        {
            return opr(nums);
        }

        public static int[] Substract(int[] nums)
        {
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = --nums[i];
            }
            return result;
        }
        public static int[] Add(int[] nums)
        {
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = ++nums[i];
            }
            return result;
        }
       
        public static int[] Multiply(int[] nums)
        {
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[i] * 2;
            }
            return result;
        }
    }
}
