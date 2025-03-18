using System;
using System.Threading;

// 自定义事件参数
public class AlarmEventArgs : EventArgs
{
    public DateTime CurrentTime { get; }

    public AlarmEventArgs(DateTime time)
    {
        CurrentTime = time;
    }
}

// 闹钟类
public class AlarmClock
{
    // 定义事件委托
    public event EventHandler<AlarmEventArgs> Tick;
    public event EventHandler<AlarmEventArgs> Alarm;

    public DateTime AlarmTime { get; set; }

    // 启动闹钟
    public void Start()
    {
        Console.WriteLine($"闹钟已启动，目标时间：{AlarmTime:HH:mm:ss}");

        while (DateTime.Now < AlarmTime)
        {
            Thread.Sleep(1000); // 模拟1秒间隔
            Tick?.Invoke(this, new AlarmEventArgs(DateTime.Now));
        }

        // 触发响铃事件
        Alarm?.Invoke(this, new AlarmEventArgs(DateTime.Now));
    }
}

class Program
{
    static void Main()
    {
        var clock = new AlarmClock
        {
            // 设置5秒后响铃
            AlarmTime = DateTime.Now.AddSeconds(5)
        };

        // 订阅嘀嗒事件
        clock.Tick += (sender, e) =>
            Console.WriteLine($"嘀嗒... 当前时间：{e.CurrentTime:HH:mm:ss}");

        // 订阅响铃事件
        clock.Alarm += (sender, e) =>
            Console.WriteLine($"时间到！当前时间：{e.CurrentTime:HH:mm:ss}");

        clock.Start();
    }
}
