using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveSpace("  Hello   World  !   你好    世界 ！ "));
            Console.ReadKey();
        }

        private static string RemoveSpace(string target)
        {
            string result = "";
            string[] word = target.Split(' ');
            for (int i = 0; i < word.Length; i++)
            {
                result += word[i];
                if(i < word.Length - 1 && word[i] != "")
                {
                    result += " ";
                }
            }
            return result;
        }
    }
}
