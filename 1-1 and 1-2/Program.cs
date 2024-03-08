using System;

namespace _1_1_and_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 对测试数据初始化，并且打印出数据。
            int n1 = 10, n2 = 20;
            Console.WriteLine("Original");
            Console.WriteLine($"{n1} {n2}");

            // 进行交换操作后打印出结果。
            SwapInt(ref n1, ref n2);
            Console.WriteLine("Swapped");
            Console.WriteLine($"{n1} {n2}");

            // 按任意键退出。
            Console.ReadKey();
        }

        /// <summary>
        /// 交换两个整型引用的值。
        /// </summary>
        private static void SwapInt(ref int a, ref int b)
        {
            // 先求出两数之和，然后分别求出两数。
            // 通过重载可用于 double 等类型。
            a = a + b;
            b = a - b;
            a = a - b;
        }
    }
}
