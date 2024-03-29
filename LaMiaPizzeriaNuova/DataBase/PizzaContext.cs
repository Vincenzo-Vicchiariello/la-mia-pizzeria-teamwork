﻿using LaMiaPizzeriaNuova.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LaMiaPizzeriaNuova.DataBase
{
    public class PizzaContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<PizzaModel> Pizze { get; set; }
        public DbSet<Drink> Bevande { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=PizzaTeamworkDb;Integrated Security=True;TrustServerCertificate=True");
        }
    }


}
