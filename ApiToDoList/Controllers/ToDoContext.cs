using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiToDoList.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiToDoList
{
    public class ToDoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=Todo.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Item>().HasKey(i => new {i.TodoId, i.ItemId});
        }

        public DbSet<Todo> Todos { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}
