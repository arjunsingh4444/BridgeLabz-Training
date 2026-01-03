using System;

class Order
{
    public int OrderId;

    public virtual string GetOrderStatus()
    {
        return "Order Placed";
    }
}

class ShippedOrder : Order
{
    public string TrackingNumber;

    public override string GetOrderStatus()
    {
        return "Order Shipped";
    }
}

class DeliveredOrder : ShippedOrder
{
    public override string GetOrderStatus()
    {
        return "Order Delivered";
    }
}

class Program
{
    static void Main()
    {
        Order o = new DeliveredOrder();
        Console.WriteLine(o.GetOrderStatus());
    }
}
