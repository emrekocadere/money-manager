using System;
using Microsoft.AspNetCore.Identity;

namespace MoneyManager.API.Entities;

public class User:IdentityUser<int>
{
    public double Balance {get;set;}
}
