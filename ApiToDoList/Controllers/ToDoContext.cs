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

        public DbSet<Todo> Todos { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}
