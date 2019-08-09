using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiToDoList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiToDoList.Services
{
    public class TodoServices : ITodoServices
    {
        public Todo AddPost(Todo todo) {
            ToDoContext context = new ToDoContext();
            context.Todos.Add(todo);
            context.SaveChanges();
            return todo;
        }

        public IEnumerable<Todo> GetTodosHeader() {
            ToDoContext context = new ToDoContext();
            return context.Todos;
        }

        public IEnumerable<Todo> GetAll() {
            ToDoContext context = new ToDoContext();
            var todos = context.Todos;

            foreach (var todo in todos) {
                todo.Items = GetItemsFromTodo(todo.ID);
            }

            return todos;
        }

        public Todo GetTodo(int id) {
            ToDoContext context = new ToDoContext();
            Todo todo = context.Todos.Find(id);
            if (todo == null) return null;
            todo.Items = context.Items.Where(i => i.TodoId == id).ToList();
            return todo;
        }

        public Todo PutTodo(Todo todo) {
            ToDoContext context = new ToDoContext();
            context.Entry(todo).State = EntityState.Modified;
            context.SaveChanges();
            return todo;
        }

        public bool DeleteTodo(int id) {
            ToDoContext context = new ToDoContext();
            Todo todo = context.Todos.Find(id);
            if(todo == null) return false;

            context.Todos.Remove(todo);
            context.SaveChanges();
            return true;
        }

        public Item AddItem(int todoId, Item item) {
            ToDoContext context = new ToDoContext();
            Todo todo = context.Todos.Find(todoId);
            if (todo == null) return null;
            context.Items.Add(item);
            context.SaveChanges();
            return item;
        }

        public ICollection<Item> GetItemsFromTodo(int todoId) {
            ToDoContext context = new ToDoContext();
            return context.Items.Where(i => i.TodoId == todoId).ToList();
        }

        public Item PutItem(Item item) {
            ToDoContext context = new ToDoContext();
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
            return item;
        }

        public bool DeleteItem(int itemId) {
            ToDoContext context = new ToDoContext();
            Item item = context.Items.Find(itemId);
            if (item == null) return false;

            context.Items.Remove(item);
            context.SaveChanges();
            return true;
        }
    }
}
