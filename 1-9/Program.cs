using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "2020年10月1日";
            var date = DateTime.Parse(str);

            Console.WriteLine($"Year: {date.Year}");
            Console.WriteLine($"Month: {date.Month}");
            Console.WriteLine($"Day: {date.Day}");
            Console.ReadKey();
        }
    }
}
