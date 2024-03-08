using System;

namespace _1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 初始化测试用字符串。
            string str = "  Hello   World  !   你好    世界 ！ ";

            // 输出原始字符串。
            Console.WriteLine("Original string: ");
            Console.WriteLine(str);

            // 输出处理后的字符串。
            Console.WriteLine("Processed string: ");
            Console.WriteLine(RemoveSpace(str));

            // 按任意键退出。
            Console.ReadKey();
        }

        /// <summary>
        /// 创建一个删除字符串中多余的空格的字符串副本，包括前置空格、后置空格以及中置多余空格。
        /// </summary>
        /// <returns>删除掉多余空格的字符串。</returns>
        private static string RemoveSpace(string target)
        {
            string result = "";

            // 使用空格作为分隔符分隔字符串。
            string[] word = target.Split(' ');

            // 连接被分隔出的单词。
            for (int i = 0; i < word.Length; i++)
            {
                result += word[i];

                // 在单词之间（排除掉因空格删除产生的空字符串）补充一个空格。
                if (i < word.Length - 1 && word[i] != "")
                {
                    result += " ";
                }
            }
            return result;
        }
    }
}
