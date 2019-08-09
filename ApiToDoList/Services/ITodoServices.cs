using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiToDoList.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiToDoList.Services
{
    public interface ITodoServices {

        IEnumerable<Todo> GetTodosHeader();
        Todo AddPost(Todo todo);
        Todo GetTodo(int id);
        Todo PutTodo(Todo todo);
        bool DeleteTodo(int id);

        IEnumerable<Todo> GetAll();

        Item AddItem(int todoId, Item item);
        ICollection<Item> GetItemsFromTodo(int todoId);
        Item PutItem(Item item);
        bool DeleteItem(int id);
    }
}
