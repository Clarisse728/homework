using System;
using System.Collections.Generic;
using System.Linq;

// 商品类
public class Product
{
    public string ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string productId, string name, decimal price)
    {
        ProductId = productId;
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"商品ID: {ProductId}, 名称: {Name}, 价格: {Price:C}";
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Product other = (Product)obj;
        return ProductId == other.ProductId;
    }

    public override int GetHashCode()
    {
        return ProductId.GetHashCode();
    }
}

// 客户类
public class Customer
{
    public string CustomerId { get; set; }
    public string Name { get; set; }

    public Customer(string customerId, string name)
    {
        CustomerId = customerId;
        Name = name;
    }

    public override string ToString()
    {
        return $"客户ID: {CustomerId}, 姓名: {Name}";
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Customer other = (Customer)obj;
        return CustomerId == other.CustomerId;
    }

    public override int GetHashCode()
    {
        return CustomerId.GetHashCode();
    }
}

// 订单明细类
public class OrderDetail
{
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public decimal TotalAmount => Product.Price * Quantity;

    public OrderDetail(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }

    public override string ToString()
    {
        return $"{Product}, 数量: {Quantity}, 小计: {TotalAmount:C}";
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        OrderDetail other = (OrderDetail)obj;
        return Product.Equals(other.Product);
    }

    public override int GetHashCode()
    {
        return Product.GetHashCode();
    }
}

// 订单类
public class Order : IComparable<Order>
{
    public string OrderId { get; set; }
    public Customer Customer { get; set; }
    public List<OrderDetail> OrderDetails { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount => OrderDetails.Sum(od => od.TotalAmount);

    public Order(string orderId, Customer customer, List<OrderDetail> orderDetails, DateTime orderDate)
    {
        OrderId = orderId;
        Customer = customer;
        OrderDetails = orderDetails;
        OrderDate = orderDate;
    }

    public void AddDetail(OrderDetail detail)
    {
        if (OrderDetails.Contains(detail))
        {
            throw new ArgumentException("订单明细已存在");
        }
        OrderDetails.Add(detail);
    }

    public void RemoveDetail(Product product)
    {
        var detail = OrderDetails.FirstOrDefault(od => od.Product.Equals(product));
        if (detail == null)
        {
            throw new ArgumentException("订单中不存在该商品的明细");
        }
        OrderDetails.Remove(detail);
    }

    public override string ToString()
    {
        string details = string.Join("\n  ", OrderDetails.Select(od => od.ToString()));
        return $"订单号: {OrderId}, 客户: {Customer}, 订单日期: {OrderDate:yyyy-MM-dd}\n" +
               $"订单明细:\n  {details}\n" +
               $"总金额: {TotalAmount:C}";
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Order other = (Order)obj;
        return OrderId == other.OrderId;
    }

    public override int GetHashCode()
    {
        return OrderId.GetHashCode();
    }

    public int CompareTo(Order other)
    {
        if (other == null) return 1;
        return OrderId.CompareTo(other.OrderId);
    }
}