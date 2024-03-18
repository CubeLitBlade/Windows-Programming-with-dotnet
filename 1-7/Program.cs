using System;

namespace _1_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 初始化无序序列，并将其打印到终端。
            int[] array = { 20, 16, 78, 61, 12, 99, 57, 34, 8 };
            Console.WriteLine("The original array is as follows: ");
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine(); 
            Console.WriteLine();

            // 使用方法对序列冒泡排序，并将其打印到终端。
            BubbleSortBy(array);
            Console.WriteLine("The original array is as follows: ");
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            // 按任意键退出。
            Console.ReadKey();
        }

        /// <summary>
        /// 使用冒泡算法完成对整型序列的排序。
        /// </summary>
        private static void BubbleSortBy(params int[] num)
        {
            int temp = 0;
            for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = i; j < num.Length; j++)
                {
                    if (num[i] > num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
        }
    }
}
