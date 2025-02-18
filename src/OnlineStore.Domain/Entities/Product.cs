﻿namespace OnlineStore.Domain.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; }
}
