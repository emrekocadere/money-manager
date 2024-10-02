using System;

namespace MoneyManager.API.Entities;

public class Expense
{
    public int Id { get; set; }
    required public Category Category { get; set; }
    required public string CategoryId { get; set; }
    required public User User { get; set; }
    public int UserId { get; set; }
    required public Account Account { get; set; }
    public int AccountId { get; set; }
    public double Amount { get; set; }
    required public string Description { get; set; }
    public double NewBalance { get; set; }
}
