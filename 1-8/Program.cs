using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "患者：“大夫，我咳嗽得很重。”     大夫：“你多大年记？”     患者：“七十五岁。”     大夫：“二十岁咳嗽吗”患者：“不咳嗽。”     大夫：“四十岁时咳嗽吗？”     患者：“也不咳嗽。”     大夫：“那现在不咳嗽，还要等到什么时咳嗽？”";
            var index = GetKeywordIndex(str, "咳嗽");
            Console.WriteLine(index.Count);
            foreach (var item in index)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// 返回
        /// </summary>
        /// <param name="target"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        private static ArrayList GetKeywordIndex(string target, string keyword)
        {
            ArrayList index = new ArrayList();

            // 寻找下一个关键词的下标。
            int i = target.IndexOf(keyword);
            while (i != -1)
            {
                index.Add(i);
                i = target.IndexOf(keyword, i + 1);
            }
            return index;

        }

    }
}
