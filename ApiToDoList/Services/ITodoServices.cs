using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiToDoList.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiToDoList.Services
{
    public interface ITodoServices
    {
        Todo AddPost(Todo todo);
        IEnumerable<Todo> GetAll();
        Todo Get(int id);
        Item AddItem(int todoId, Item item);
        IEnumerable<Item> GetItemsFromTodo(int todoId);
    }
}
