using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        OrderService orderService = new OrderService();
        bool running = true;

        InitializeTestData(orderService);

        while (running)
        {
            Console.WriteLine("\n订单管理系统");
            Console.WriteLine("1. 添加订单");
            Console.WriteLine("2. 删除订单");
            Console.WriteLine("3. 修改订单");
            Console.WriteLine("4. 查询订单");
            Console.WriteLine("5. 显示所有订单");
            Console.WriteLine("6. 排序订单");
            Console.WriteLine("0. 退出");
            Console.Write("请选择操作: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("无效输入，请输入数字！");
                continue;
            }

            try
            {
                switch (choice)
                {
                    case 1:
                        AddOrder(orderService);
                        break;
                    case 2:
                        RemoveOrder(orderService);
                        break;
                    case 3:
                        UpdateOrder(orderService);
                        break;
                    case 4:
                        QueryOrders(orderService);
                        break;
                    case 5:
                        DisplayAllOrders(orderService);
                        break;
                    case 6:
                        SortOrders(orderService);
                        break;
                    case 0:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("无效选择，请重新输入！");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"操作失败: {ex.Message}");
            }
        }
    }

    static void InitializeTestData(OrderService orderService)
    {
        Product product1 = new Product("P001", "笔记本电脑", 5999m);
        Product product2 = new Product("P002", "手机", 3999m);
        Product product3 = new Product("P003", "耳机", 299m);

        Customer customer1 = new Customer("C001", "张三");
        Customer customer2 = new Customer("C002", "李四");

        var order1Details = new System.Collections.Generic.List<OrderDetail>
        {
            new OrderDetail(product1, 1),
            new OrderDetail(product3, 2)
        };
        var order1 = new Order("O001", customer1, order1Details, DateTime.Now);

        var order2Details = new System.Collections.Generic.List<OrderDetail>
        {
            new OrderDetail(product2, 1),
            new OrderDetail(product3, 1)
        };
        var order2 = new Order("O002", customer2, order2Details, DateTime.Now);

        try
        {
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"初始化测试数据时出错: {ex.Message}");
        }
    }

    static void AddOrder(OrderService orderService)
    {
        Console.WriteLine("\n添加新订单");

        Console.Write("订单号: ");
        string orderId = Console.ReadLine();

        Console.Write("客户ID: ");
        string customerId = Console.ReadLine();

        Console.Write("客户姓名: ");
        string customerName = Console.ReadLine();

        var customer = new Customer(customerId, customerName);
        var orderDetails = new System.Collections.Generic.List<OrderDetail>();

        bool addingProducts = true;
        while (addingProducts)
        {
            Console.Write("商品ID (输入空行结束): ");
            string productId = Console.ReadLine();
            if (string.IsNullOrEmpty(productId)) break;

            Console.Write("商品名称: ");
            string productName = Console.ReadLine();

            Console.Write("商品价格: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("数量: ");
            int quantity = int.Parse(Console.ReadLine());

            var product = new Product(productId, productName, price);
            orderDetails.Add(new OrderDetail(product, quantity));
        }

        var order = new Order(orderId, customer, orderDetails, DateTime.Now);
        orderService.AddOrder(order);
        Console.WriteLine("订单添加成功！");
    }

    static void RemoveOrder(OrderService orderService)
    {
        Console.WriteLine("\n删除订单");
        Console.Write("请输入要删除的订单号: ");
        string orderId = Console.ReadLine();

        orderService.RemoveOrder(orderId);
        Console.WriteLine("订单删除成功！");
    }

    static void UpdateOrder(OrderService orderService)
    {
        Console.WriteLine("\n修改订单");
        Console.Write("请输入要修改的订单号: ");
        string orderId = Console.ReadLine();

        var existingOrder = orderService.GetAllOrders().FirstOrDefault(o => o.OrderId == orderId);
        if (existingOrder == null)
        {
            Console.WriteLine("订单不存在！");
            return;
        }

        Console.WriteLine("当前订单信息:");
        Console.WriteLine(existingOrder);

        Console.Write("新的客户ID (留空保持不变): ");
        string customerId = Console.ReadLine();

        Console.Write("新的客户姓名 (留空保持不变): ");
        string customerName = Console.ReadLine();

        var customer = string.IsNullOrEmpty(customerId) && string.IsNullOrEmpty(customerName)
            ? existingOrder.Customer
            : new Customer(
                string.IsNullOrEmpty(customerId) ? existingOrder.Customer.CustomerId : customerId,
                string.IsNullOrEmpty(customerName) ? existingOrder.Customer.Name : customerName);

        var orderDetails = new System.Collections.Generic.List<OrderDetail>();
        Console.WriteLine("重新输入订单明细 (将替换原有明细):");

        bool addingProducts = true;
        while (addingProducts)
        {
            Console.Write("商品ID (输入空行结束): ");
            string productId = Console.ReadLine();
            if (string.IsNullOrEmpty(productId)) break;

            Console.Write("商品名称: ");
            string productName = Console.ReadLine();

            Console.Write("商品价格: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("数量: ");
            int quantity = int.Parse(Console.ReadLine());

            var product = new Product(productId, productName, price);
            orderDetails.Add(new OrderDetail(product, quantity));
        }

        if (!orderDetails.Any())
        {
            orderDetails = existingOrder.OrderDetails;
        }

        var updatedOrder = new Order(orderId, customer, orderDetails, existingOrder.OrderDate);
        orderService.UpdateOrder(updatedOrder);
        Console.WriteLine("订单修改成功！");
    }

    static void QueryOrders(OrderService orderService)
    {
        Console.WriteLine("\n查询订单");
        Console.WriteLine("1. 按订单号查询");
        Console.WriteLine("2. 按商品名称查询");
        Console.WriteLine("3. 按客户查询");
        Console.WriteLine("4. 按金额范围查询");
        Console.Write("请选择查询方式: ");

        int queryType = int.Parse(Console.ReadLine());

        switch (queryType)
        {
            case 1:
                Console.Write("请输入订单号: ");
                string orderId = Console.ReadLine();
                var ordersById = orderService.QueryByOrderId(orderId);
                DisplayQueryResults(ordersById);
                break;
            case 2:
                Console.Write("请输入商品名称: ");
                string productName = Console.ReadLine();
                var ordersByProduct = orderService.QueryByProductName(productName);
                DisplayQueryResults(ordersByProduct);
                break;
            case 3:
                Console.Write("请输入客户姓名: ");
                string customerName = Console.ReadLine();
                var ordersByCustomer = orderService.QueryByCustomer(customerName);
                DisplayQueryResults(ordersByCustomer);
                break;
            case 4:
                Console.Write("请输入最小金额: ");
                decimal minAmount = decimal.Parse(Console.ReadLine());
                Console.Write("请输入最大金额: ");
                decimal maxAmount = decimal.Parse(Console.ReadLine());
                var ordersByAmount = orderService.QueryByAmountRange(minAmount, maxAmount);
                DisplayQueryResults(ordersByAmount);
                break;
            default:
                Console.WriteLine("无效的查询类型！");
                break;
        }
    }

    static void DisplayQueryResults(System.Collections.Generic.List<Order> orders)
    {
        if (!orders.Any())
        {
            Console.WriteLine("没有找到匹配的订单！");
            return;
        }

        Console.WriteLine($"找到 {orders.Count} 条订单:");
        foreach (var order in orders)
        {
            Console.WriteLine(order);
            Console.WriteLine("----------------------");
        }
    }

    static void DisplayAllOrders(OrderService orderService)
    {
        var allOrders = orderService.GetAllOrders();
        DisplayQueryResults(allOrders);
    }

    static void SortOrders(OrderService orderService)
    {
        Console.WriteLine("\n排序订单");
        Console.WriteLine("1. 按订单号排序 (默认)");
        Console.WriteLine("2. 按总金额排序");
        Console.WriteLine("3. 按订单日期排序");
        Console.Write("请选择排序方式: ");

        int sortType = int.Parse(Console.ReadLine());

        switch (sortType)
        {
            case 1:
                orderService.SortOrders();
                Console.WriteLine("已按订单号排序");
                break;
            case 2:
                orderService.SortOrders((o1, o2) => o1.TotalAmount.CompareTo(o2.TotalAmount));
                Console.WriteLine("已按总金额排序");
                break;
            case 3:
                orderService.SortOrders((o1, o2) => o1.OrderDate.CompareTo(o2.OrderDate));
                Console.WriteLine("已按订单日期排序");
                break;
            default:
                Console.WriteLine("无效的排序类型！");
                break;
        }
    }
}