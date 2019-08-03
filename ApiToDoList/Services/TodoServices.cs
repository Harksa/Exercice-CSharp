using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiToDoList.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiToDoList.Services
{
    public class TodoServices : ITodoServices
    {
        private readonly ToDoContext _context;

        public TodoServices() {
            _context = new ToDoContext();
        }

        public Todo AddPost(Todo todo) {
            _context.Todos.Add(todo);
            _context.SaveChanges();
            return todo;
        }

        public IEnumerable<Todo> GetAll() {
            List<Todo> todos = _context.Todos.ToList();

            foreach (var todo in todos) {
                todo.Items = _context.Items.Where(i => i.TodoList.ID == todo.ID).ToList();
            }

            return todos;
        }

        public Todo Get(int id) {
            Todo todo = _context.Todos.Find(id);
            if (todo == null) return null;
            todo.Items = _context.Items.Where(i => i.TodoList.ID == id).ToList();
            return todo;
        }

        public Item AddItem(int todoId, Item item) {
            Todo todo = _context.Todos.Find(todoId);
            if (todo == null) return null;
            _context.Items.Add(item);
            _context.SaveChanges();
            return item;
        }

        public IEnumerable<Item> GetItemsFromTodo(int todoId) { 
            return _context.Items.Where(i => i.TodoList.ID == todoId).ToList();
        }
    }
}
