using System;

namespace _1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of random numbers: ");
            uint n = Convert.ToUInt32(Console.ReadLine());

            // 初始化随机数发生器，用于生成数组
            Random rd = new Random();
            double[] num = new double[n];

            // 生成随机数序列。
            Console.WriteLine($"Generated {n} random numbers: ");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = rd.Next(100);
                Console.Write($"{num[i]} ");
            }
            Console.WriteLine();

            // 调用方法输出最大值。
            Console.WriteLine($"The max value in the above list is {Max(num)}. ");

            // 按任意键退出。
            Console.ReadKey();
        }

        /// <summary>
        /// 返回参数中最大的数值。
        /// </summary>
        /// <returns>参数中数值最大的值。</returns>
        private static double Max(params double[] x)
        {
            // 默认将序列中的第一个数作为最大值。
            // 然后遍历序列，不断替换最大值。
            double result = x[0];
            foreach (double i in x)
            {
                if (i > result)
                    result = i;
            }
            return result;
        }
    }
}
