namespace PizzaDelivery.Models;


public class Order
{
    public int Id {get; set;}
    public DateTime OrderPlaced {get; set;}
    public DateTime? OrderFulfilled {get; set;}
    public int CostumerId {get; set;}
    public Costumer Costumer {get; set;} = null;
    public ICollection<OrderDetail> OrderDetails {get; set;} = null;
}

