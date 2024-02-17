
using Microsoft.EntityFrameworkCore;
using Practica1.modal;
using System;

namespace Practica1.Repozidori
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Samolet>? Samolet { get; set; }
    }
}