using System;

namespace MoneyManager.API.Entities;

public class Account
{
    public int Id { get; set; }
    required public string Name { get; set; }
    required public User User { get; set; }
    public int UserId { get; set; }
    public double Balance{ get; set; }
}
