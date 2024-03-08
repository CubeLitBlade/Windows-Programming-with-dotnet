using System;

namespace _1_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 利用 DateTime.Parse 方法将字符串转换为 DateTime 类型。
            string str = "2020年10月1日";
            var date = DateTime.Parse(str);

            // 分别输出此 DateTime 的相应元素。
            Console.WriteLine($"Year: {date.Year}");
            Console.WriteLine($"Month: {date.Month}");
            Console.WriteLine($"Day: {date.Day}");

            // 按任意键退出。
            Console.ReadKey();
        }
    }
}
