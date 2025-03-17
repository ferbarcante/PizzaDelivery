using Microsoft.EntityFrameworkCore;
using PizzaDelivery.Models;

namespace PizzaDelivery.Data;

public class ContosoPizzaContext : DbContext // A classe ContosoPizzaContext herda de DbContext, que é a classe base do Entity Framework Core para gerenciar a conexão com o banco de dados e operações relacionadas.
{
    // DbSet<T>: Representa uma coleção de entidades (tabelas) no banco de dados.
    public DbSet<Costumer> Costumers {get; set;} = null;
    public DbSet<Order> Orders {get; set;} = null;
    public DbSet<Product> Products {get; set;} = null;
    public DbSet<OrderDetail> OrderDetails {get; set;} = null;

    // Método usado para configurar a conexão com o banco de dados
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Connection String Here");
    }
}