using System;

class Program
{
    static void Main(string[] args)
    {
        // 创建布尔数组，初始值为true
        bool[] isPrime = new bool[101];
        for (int i = 0; i <= 100; i++)
        {
            isPrime[i] = true;
        }

        // 标记非素数
        // 标记2的倍数
        for (int i = 4; i <= 100; i += 2)
        {
            isPrime[i] = false;
        }

        // 标记3的倍数
        for (int i = 9; i <= 100; i += 3)
        {
            isPrime[i] = false;
        }

        // 标记5的倍数
        for (int i = 25; i <= 100; i += 5)
        {
            isPrime[i] = false;
        }

        // 标记7的倍数
        for (int i = 49; i <= 100; i += 7)
        {
            isPrime[i] = false;
        }

        // 输出结果
        Console.WriteLine("2~100之间的素数有：");
        for (int i = 2; i <= 100; i++)
        {
            if (isPrime[i])
            {
                Console.Write(i + " ");
            }
        }

        // 按下任意键结束程序
        Console.ReadKey();
    }
}
