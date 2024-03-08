using System;

namespace _1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 读取两个浮点数作为运算数。
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            // 执行四则运算后输出。
            Arithmetic(a, b, out var sum, out var difference, out var product, out var quotient);
            Console.WriteLine($"{a} + {b} = {sum}");
            Console.WriteLine($"{a} - {b} = {difference}");
            Console.WriteLine($"{a} * {b} = {product}");
            Console.WriteLine($"{a} / {b} = {quotient}");

            // 按任意键退出。
            Console.ReadKey();
        }

        /// <summary>
        /// 完成两个数的四则运算。
        /// </summary>
        /// <param name="a">第一个运算数。</param>
        /// <param name="b">第二个运算数。</param>
        /// <param name="sum">输出这两个数的和。</param>
        /// <param name="difference">输出这两个数的差。</param>
        /// <param name="product">输出这两个数的积。</param>
        /// <param name="quotient">输入这两个数的差。</param>
        private static void Arithmetic(double a, double b, out double sum, out double difference, out double product, out double quotient)
        {
            sum = a + b;
            difference = a - b;
            product = a * b;
            quotient = a / b;
        }
    }
}
