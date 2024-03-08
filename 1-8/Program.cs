using System;
using System.Collections;

namespace _1_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 初始化目标字符串。
            string str = "患者：“大夫，我咳嗽得很重。”     大夫：“你多大年记？”     患者：“七十五岁。”     大夫：“二十岁咳嗽吗”患者：“不咳嗽。”     大夫：“四十岁时咳嗽吗？”     患者：“也不咳嗽。”     大夫：“那现在不咳嗽，还要等到什么时咳嗽？”";

            // 查找字符串的下标并输出其关键词数量。
            var index = GetKeywordIndex(str, "咳嗽");
            Console.WriteLine($"{index.Count} keyword(s) found in this string. ");

            // 输出关键词所在的下标。
            Console.WriteLine("Keyword(s) Index: ");
            foreach (var item in index)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            //按任意键退出。
            Console.ReadKey();
        }

        /// <summary>
        /// 返回字符串中存在的所有关键词的下标序列。
        /// </summary>
        /// <param name="target">目标字符串。</param>
        /// <param name="keyword">待寻找的关键词。</param>
        /// <returns>字符串中所包含关键词的下标序列。</returns>
        private static ArrayList GetKeywordIndex(string target, string keyword)
        {
            ArrayList index = new ArrayList();

            // 寻找下一个关键词的下标。
            int i = target.IndexOf(keyword);

            // 寻找的下标为 -1 时，表示找不到关键词，可以直接退出循环。
            while (i != -1)
            {
                // 如果能找到下标，就将这个下标计入序列，同时从下标后开始继续寻找。
                index.Add(i);
                i = target.IndexOf(keyword, i + 1);
            }
            return index;

        }

    }
}
