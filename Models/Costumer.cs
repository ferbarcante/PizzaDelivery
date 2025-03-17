namespace PizzaDelivery.Models;

public class Costumer 
{
    public int Id {get; set;}
    public string FirstName {get; set;} = null;
    public string LastName {get; set;} = null; // o banco de dados não irá permitir que registre como nulo
    public string? Address {get; set;}
    public string? Phone {get; set;} // o ? indica que o valor pode ser armazenado como nulo
    public ICollection<Order> Orders {get; set;} = null; 
    /* gera o relacionamento de um para muitos (1:N)
    um objeto de costumer pode estar associado a muitos objetos da entidade Order
    */
}  
