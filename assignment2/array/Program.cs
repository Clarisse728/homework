using System;

class Program
{
    static void Main(string[] args)
    {
        // 提示用户输入一个整数数组，元素用逗号分隔
        Console.WriteLine("请输入一个整数数组，元素用英文逗号分隔，例如：5,3,8,2,9,1,6");
        string input = Console.ReadLine();

        // 将输入的字符串转换为整数数组
        string[] inputStrings = input.Split(',');
        int[] numbers = new int[inputStrings.Length];
        for (int i = 0; i < inputStrings.Length; i++)
        {
            if (int.TryParse(inputStrings[i], out int num))
            {
                numbers[i] = num;
            }
            else
            {
                // 如果输入无效，可以处理错误或提示用户
                Console.WriteLine("输入无效，请确保输入的是整数！");
                return;
            }
        }

        // 计算最大值
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine("最大值: {0}", max);

        // 计算最小值
        int min = numbers[0];
        foreach (int num in numbers)
        {
            if (num < min)
            {
                min = num;
            }
        }
        Console.WriteLine("最小值: {0}", min);

        // 计算所有元素的和
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine("总和: {0}", sum);

        // 计算平均值
        double average = (double)sum / numbers.Length;
        Console.WriteLine("平均值: {0:F2}", average);

        // 按下任意键结束程序
        Console.ReadKey();
    }
}
