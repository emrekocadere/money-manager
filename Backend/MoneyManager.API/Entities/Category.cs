using System;

namespace MoneyManager.API.Entities;

public class Category
{
    public int Id{get; set;}
    required public string Name{get; set;}
    public User? User{get; set;}
    public int? UserId{get; set;}
}
