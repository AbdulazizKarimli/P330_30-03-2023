namespace Core.Entities;

public class Shop
{
    public List<Order> Orders { get; set; }
    public Shop()
    {
        Orders = new List<Order>();
    }

    public void AddOrder(Order order)
    {
        Orders.Add(order);
    }

    public decimal GetOrdersAvg()
    {
        return Orders.Average(o => o.TotalAmount);
    }

    public void RemoveOrderByNo(int no)
    {
        Order order = Orders.Find(o => o.No == no);
        Orders.Remove(order);
    }

    public List<Order> FilterOrderByPrice(decimal minPrice, decimal maxPrice)
    {
        return Orders.FindAll(o => o.TotalAmount >= minPrice && o.TotalAmount <= maxPrice);
    }
}
