public class OrderService
{
    private List<Order> orders = new List<Order>();

    // 添加订单
    public void AddOrder(Order order)
    {
        if (orders.Contains(order))
        {
            throw new ArgumentException("订单已存在");
        }
        orders.Add(order);
    }

    // 删除订单
    public void RemoveOrder(string orderId)
    {
        var order = orders.FirstOrDefault(o => o.OrderId == orderId);
        if (order == null)
        {
            throw new ArgumentException($"订单号 {orderId} 不存在");
        }
        orders.Remove(order);
    }

    // 修改订单
    public void UpdateOrder(Order order)
    {
        var existingOrder = orders.FirstOrDefault(o => o.OrderId == order.OrderId);
        if (existingOrder == null)
        {
            throw new ArgumentException($"订单号 {order.OrderId} 不存在");
        }
        orders.Remove(existingOrder);
        orders.Add(order);
    }

    // 查询所有订单
    public List<Order> GetAllOrders()
    {
        return orders.OrderBy(o => o.OrderId).ToList();
    }

    // 按订单号查询
    public List<Order> QueryByOrderId(string orderId)
    {
        return orders.Where(o => o.OrderId == orderId)
                     .OrderBy(o => o.TotalAmount)
                     .ToList();
    }

    // 按商品名称查询
    public List<Order> QueryByProductName(string productName)
    {
        return orders.Where(o => o.OrderDetails.Any(od => od.Product.Name.Contains(productName)))
                     .OrderBy(o => o.TotalAmount)
                     .ToList();
    }

    // 按客户查询
    public List<Order> QueryByCustomer(string customerName)
    {
        return orders.Where(o => o.Customer.Name.Contains(customerName))
                     .OrderBy(o => o.TotalAmount)
                     .ToList();
    }

    // 按金额范围查询
    public List<Order> QueryByAmountRange(decimal minAmount, decimal maxAmount)
    {
        return orders.Where(o => o.TotalAmount >= minAmount && o.TotalAmount <= maxAmount)
                     .OrderBy(o => o.TotalAmount)
                     .ToList();
    }

    // 排序方法
    public void SortOrders(Comparison<Order> comparison = null)
    {
        if (comparison == null)
        {
            orders.Sort();
        }
        else
        {
            orders.Sort(comparison);
        }
    }
}