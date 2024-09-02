using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MoneyManager.API.Entities;

namespace MoneyManager.API;

public class MoneyManagerDbContext:IdentityDbContext<User,Role,int>
{
    public MoneyManagerDbContext(DbContextOptions<MoneyManagerDbContext> options):base(options)
    {
        
    }
    
}
