using System;

// 定义泛型链表节点
public class Node<T>
{
    public T Data { get; set; }
    public Node<T> Next { get; set; }

    public Node(T data)
    {
        Data = data;
        Next = null;
    }
}

// 定义泛型链表类
public class LinkedList<T>
{
    private Node<T> head;

    // 添加元素到链表
    public void Add(T item)
    {
        if (head == null)
        {
            head = new Node<T>(item);
        }
        else
        {
            Node<T> current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new Node<T>(item);
        }
    }

    // 添加 ForEach 方法
    public void ForEach(Action<T> action)
    {
        Node<T> current = head;
        while (current != null)
        {
            action(current.Data);
            current = current.Next;
        }
    }
}

// 测试代码
class Program
{
    static void Main()
    {
        // 创建一个整数链表并添加元素
        LinkedList<int> list = new LinkedList<int>();
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);
        list.Add(50);

        // 打印链表元素
        Console.WriteLine("链表元素:");
        list.ForEach(item => Console.WriteLine(item));

        // 求最大值
        int max = int.MinValue;
        list.ForEach(item => max = Math.Max(max, item));
        Console.WriteLine($"最大值: {max}");

        // 求最小值
        int min = int.MaxValue;
        list.ForEach(item => min = Math.Min(min, item));
        Console.WriteLine($"最小值: {min}");

        // 求和
        int sum = 0;
        list.ForEach(item => sum += item);
        Console.WriteLine($"求和: {sum}");
    }
}