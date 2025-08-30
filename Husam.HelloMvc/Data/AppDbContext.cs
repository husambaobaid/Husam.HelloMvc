using System.Collections.Generic;
using Husam.HelloMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace Husam.HelloMvc.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Todo> Todos => Set<Todo>();
    }
}