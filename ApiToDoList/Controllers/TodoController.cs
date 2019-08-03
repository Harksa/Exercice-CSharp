using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiToDoList.Models;
using ApiToDoList.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiToDoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase 
    {
        private readonly ITodoServices _services;

        public TodoController(ITodoServices services) {
            _services = services;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Todo>> Get() {
            var todos = _services.GetAll();
            if (!todos.Any()) return NotFound();
            return Ok(todos);
        }

        [HttpGet("{id}")]
        public ActionResult<Todo> Get(int id) {
            var todo = _services.Get(id);
            if (todo == null) return NotFound();
            return Ok(todo);
        }

        [HttpGet("{id}/items")]
        public ActionResult<IEnumerable<Item>> GetItems(int id) {
            var items = _services.GetItemsFromTodo(id);
            if (items == null) return NotFound();
            return Ok(items);
        }

        [HttpPost("{id}/items")]
        public ActionResult<IEnumerable<Item>> PostItem(Item item) {
            var items = _services.AddItem(item.TodoList.ID, item);
            if (items == null) return NotFound();
            return Ok(items);
        }

        [HttpPost]
        public ActionResult<Todo> Post(Todo todo) {
            var todos = _services.AddPost(todo);
            if (todos == null) return NotFound();
            return Ok(todos);
        }
    }
}
