using PizzaDelivery.Data;
using PizzaDelivery.Models;

using ContosoPizzaContext context = new ContosoPizzaContext();

Product veggieSpecial = new Product()
{
    Name = "Veggie Special Pizza",
    Price = 9.99M
};

context.Products.Add(veggieSpecial);

Product deluxeMeat = new Product()
{
    Name = "Deluxe Pizza Meat",
    Price = 12.99M
};

context.Add(deluxeMeat);

context.SaveChanges();