using System;
using System.Collections.Generic;

public class Customer
{
    private string name;
    private Dictionary<int, Order> orders = new Dictionary<int, Order>();
    private static int orderIdCounter = 1;

    public Customer(string name)
    {
        this.name = name;
    }

    public int PlaceOrder(ShoppingCart shoppingCart)
    {
        int orderId = orderIdCounter++;
        Order order = new Order(orderId, shoppingCart);
        orders[orderId] = order;
        return orderId;
    }

    public void DisplayOrder(int orderId)
    {
        if (orders.ContainsKey(orderId))
        {
            Order order = orders[orderId];
            Console.WriteLine($"Order ID: {order.OrderId}");
            Console.WriteLine("Products:");
            foreach (var pair in order.ShoppingCart.Products)
            {
                Console.WriteLine($"{pair.Key.Name}: {pair.Value}");
            }
            Console.WriteLine($"Total: ${order.ShoppingCart.CalculateTotal()}");
        }
        else
        {
            Console.WriteLine($"Order with ID {orderId} not found.");
        }
    }
}
