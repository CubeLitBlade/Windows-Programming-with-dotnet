using System;

namespace _1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 调用方法打印索引到 10 的杨辉三角。
            PrintPascalTriangle(10);

            // 按任意键退出。
            Console.ReadKey();
        }

        /// <summary>
        /// 打印索引到 n 的杨辉三角。
        /// </summary>
        private static void PrintPascalTriangle(uint n)
        {
            for (uint i = 0; i <= n; i++)
            {
                // 添加空格用于打印居中的杨辉三角。
                // 由于未能解决杨辉三角无法对齐的问题，暂时弃用。
                // Console.Write("".PadLeft((int)(n - i)));

                // 打印杨辉三角的数值段内容。
                for (uint j = 0; j <= i; j++)
                {
                    // 杨辉三角的各个元素是相应位置的组合数。
                    Console.Write($"{GetCombinatorialNumber(j, i)}\t");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 获取组合数 C(n, m) 的值。
        /// </summary>
        /// <returns>若 n <= m，返回C(n, m)的值；否则返回 0.</returns>
        private static uint GetCombinatorialNumber(uint n, uint m)
        {
            if (n <= m)
            {
                // 在满足组合数条件时，采用简化公式连乘连除计算组合数。
                // 不使用阶乘，减少计算量。
                uint result = 1;
                for (uint i = 1; i <= n; i++, m--)
                {
                    result *= m;
                    result /= i;
                }
                return result;

            }
            else
            {
                // 数学上的组合数要求 n <= m。
                // 在此，若不满足此条件，统一返回0.
                return 0;
            }
        }
    }
}
