using System;

namespace _1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 调用方法输出斐波那契数列前 20 项和。
            Console.WriteLine($"The first 20 terms of the Fibonacci add up to {FibonacciSumOf(20)}. ");

            // 按任意键退出。
            Console.ReadKey();
        }

        /// <summary>
        /// 输出斐波那契数列的第n项。
        /// </summary>
        /// <param name="n">斐波那契数列的项数。 </param>
        /// <returns>斐波那契数列第n项的值。 </returns>
        private static uint Fibonacci(uint n)
        {
            if (n <= 1)
            {
                // 斐波那契数列的第1项固定为1.
                return 1;
            }
            else
            {
                // 斐波那契数列的其它项均为前两项之和.
                uint[] term = new uint[n];

                // 前两项恒定为1.
                term[0] = 1;
                term[1] = 1;

                // 通过循环逐项求斐波那契数列
                // 由于 i 的索引从 0 开始，需要保证最高项 i + 2 不超出范围，即小于 Length - 2 .
                for (int i = 0; i < term.Length - 2; i++)
                {
                    term[i + 2] = term[i] + term[i + 1];
                }
                return term[n - 1];
            }
        }

        /// <summary>
        /// 返回斐波那契数列前 n 项之和。
        /// </summary>
        /// <returns>斐波那契数列前 n 项之和。</returns>
        private static uint FibonacciSumOf(uint n)
        {
            uint result = 0;

            // 将斐波那契前 n 项依次相加. 
            for (uint i = 0; i < n; i++)
            {
                result += Fibonacci(i + 1);
            }
            return result;
        }
    }
}
