using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = " ";
            int number = 0;
            Console.Write("请输入数字：");
            s = Console.ReadLine();
            number = int.Parse(s);
            
            for(int x=2;x*x <= number; x++)
            {
                while (number % x == 0)
                {
                    Console.WriteLine(x);
                    number = number / x;
                }
            }

            if (number != 1)
            {
                Console.WriteLine(number);
            }
        }
    }
}
