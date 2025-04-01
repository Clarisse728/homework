using System;
using System.Collections.Generic;
using System.Linq;

namespace assignment6
{
    class OrderDetails
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; } = string.Empty;
        public string OrderCustomer { get; set; } = string.Empty;
        public int OrderAmount { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is OrderDetails other)
            {
                return OrderId == other.OrderId &&
                       OrderName == other.OrderName &&
                       OrderCustomer == other.OrderCustomer &&
                       OrderAmount == other.OrderAmount;
            }
            return false;
        }

        public override string ToString()
        {
            return $"OrderId: {OrderId}, OrderName: {OrderName}, OrderCustomer: {OrderCustomer}, OrderAmount: {OrderAmount}\n";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(OrderId, OrderName, OrderCustomer, OrderAmount);
        }
    }

    class Order : OrderDetails
    {
        public Order(int orderId, string orderName, string orderCustomer, int orderAmount)
        {
            OrderId = orderId;
            OrderName = orderName;
            OrderCustomer = orderCustomer;
            OrderAmount = orderAmount;
        }
    }

    class OrderService
    {
        private List<Order> OrderList = new List<Order>();

        public List<Order> GetOrderList()
        {
            return OrderList;
        }

        public void AddOrder()
        {
            Console.WriteLine("Enter Order Id:");
            int orderId = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Enter Order Name:");
            string orderName = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Enter Order Customer:");
            string orderCustomer = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Enter Order Amount:");
            int orderAmount = int.Parse(Console.ReadLine() ?? "0");

            var order = new Order(orderId, orderName, orderCustomer, orderAmount);
            if (OrderList.Any(o => o.Equals(order)))
            {
                Console.WriteLine("Order Already Exists.");
                return;
            }

            OrderList.Add(order);
            Console.WriteLine("Order Added Successfully.");
        }

        public void AddOrder(int orderId, string orderName, string orderCustomer, int orderAmount)
        {
            var order = new Order(orderId, orderName, orderCustomer, orderAmount);
            if (OrderList.Any(o => o.Equals(order)))
            {
                Console.WriteLine("Order Already Exists.");
                return;
            }

            OrderList.Add(order);
            Console.WriteLine("Order Added Successfully.");
        }

        public void DeleteOrder()
        {
            Console.WriteLine("Enter Order Id to Delete:");
            int orderId = int.Parse(Console.ReadLine() ?? "0");

            var order = OrderList.FirstOrDefault(o => o.OrderId == orderId);
            if (order != null)
            {
                Console.WriteLine("Find Order, Ensure To Delete It? (y/n)");
                string input = Console.ReadLine() ?? string.Empty;
                if (input.ToLower() != "n" && input.ToLower() != "no")
                {
                    OrderList.Remove(order);
                    Console.WriteLine("Order Deleted Successfully.");
                }
            }
            else
            {
                throw new InvalidOperationException("No Order Deleted.");
            }
        }

        public void DeleteOrder(int orderId)
        {
            var order = OrderList.FirstOrDefault(o => o.OrderId == orderId);
            if (order != null)
            {
                Console.WriteLine("Find Order, Ensure To Delete It? (y/n)");
                string input = Console.ReadLine() ?? string.Empty;
                if (input.ToLower() != "n" && input.ToLower() != "no")
                {
                    OrderList.Remove(order);
                    Console.WriteLine("Order Deleted Successfully.");
                }
            }
            else
            {
                throw new InvalidOperationException("No Order Deleted.");
            }
        }

        public void ChangeOrder()
        {
            Console.WriteLine("Enter Order Id to Change:");
            int orderId = int.Parse(Console.ReadLine() ?? "0");

            var order = OrderList.FirstOrDefault(o => o.OrderId == orderId);
            if (order != null)
            {
                Console.WriteLine("Change Order Name? (input empty to skip)");
                string orderName = Console.ReadLine() ?? string.Empty;
                if (!string.IsNullOrEmpty(orderName))
                {
                    order.OrderName = orderName;
                }

                Console.WriteLine("Change Order Customer? (input empty to skip)");
                string orderCustomer = Console.ReadLine() ?? string.Empty;
                if (!string.IsNullOrEmpty(orderCustomer))
                {
                    order.OrderCustomer = orderCustomer;
                }

                Console.WriteLine("Change Order Amount? (input empty to skip)");
                string orderAmountStr = Console.ReadLine() ?? string.Empty;
                if (int.TryParse(orderAmountStr, out int orderAmount))
                {
                    order.OrderAmount = orderAmount;
                }

                Console.WriteLine("Order Changed Successfully.");
            }
            else
            {
                throw new InvalidOperationException("Order Not Found.");
            }
        }

        public void SortOrderList(List<Order> orderList, string sortType)
        {
            switch (sortType)
            {
                case "OrderId":
                    orderList.Sort((x, y) => x.OrderId.CompareTo(y.OrderId));
                    break;
                case "OrderName":
                    orderList.Sort((x, y) => x.OrderName.CompareTo(y.OrderName));
                    break;
                case "OrderCustomer":
                    orderList.Sort((x, y) => x.OrderCustomer.CompareTo(y.OrderCustomer));
                    break;
                case "OrderAmount":
                    orderList.Sort((x, y) => x.OrderAmount.CompareTo(y.OrderAmount));
                    break;
            }
        }

        public List<Order> SearchOrderLINQ()
        {
            Console.WriteLine("Which Order Information to Search? (1-OrderId, 2-OrderName, 3-OrderCustomer, 4-OrderAmount):");
            int searchType = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Enter Search Value:");
            string searchValue = Console.ReadLine() ?? string.Empty;

            List<Order> searchResult = SearchOrderLINQ(searchType, searchValue);
            return searchResult;
        }

        public List<Order> SearchOrderLINQ(int searchType, string searchValue)
        {
            List<Order> searchResult = new List<Order>();

            switch (searchType)
            {
                case 1:
                    if (int.TryParse(searchValue, out int orderIdValue))
                    {
                        searchResult = OrderList.Where(o => o.OrderId == orderIdValue).ToList();
                    }
                    break;
                case 2:
                    searchResult = OrderList.Where(o => o.OrderName == searchValue).ToList();
                    break;
                case 3:
                    searchResult = OrderList.Where(o => o.OrderCustomer == searchValue).ToList();
                    break;
                case 4:
                    if (int.TryParse(searchValue, out int orderAmountValue))
                    {
                        searchResult = OrderList.Where(o => o.OrderAmount == orderAmountValue).ToList();
                    }
                    break;
            }

            if (searchResult.Count > 0)
            {
                Console.WriteLine("Get Search Result.");
                SortOrderList(searchResult, "OrderAmount");
                return searchResult;
            }
            else
            {
                Console.WriteLine("No Result Found.");
                return null;
            }
        }
    }
}