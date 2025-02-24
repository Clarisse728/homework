using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            double a = 0;
            double b = 0;
            Console.Write("请输入第一个数字：");
            s = Console.ReadLine();
            a = Double.Parse(s);
            Console.Write("请输入第二个数字：");
            s = Console.ReadLine();
            b = Double.Parse(s);
            Console.Write("请输入运算符：");
            s = Console.ReadLine();
      
            switch (s) 
            {
                case "+":
                    Console.WriteLine($"{a + b}");
                    break;

                case "-":
                    Console.WriteLine($"{a - b}");
                    break;

                case "*":
                    Console.WriteLine($"{a * b}");
                    break;

                case "/":
                    if (b == 0)
                        Console.WriteLine("除数不能为0");
                    else
                    {
                        Console.WriteLine($"{a / b}");
                    }
                    break;

                case "%":
                    if (b == 0)
                        Console.WriteLine("除数不能为0");
                    else
                    {
                        Console.WriteLine($"{a % b}");
                    }
                    break;

                default:
                    Console.WriteLine($"您输入的运算符不符合规范，请重新输入");
                    break;

            }
        }
    }
}
