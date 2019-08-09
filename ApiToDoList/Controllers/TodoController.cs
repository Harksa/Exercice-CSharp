using System.Collections.Generic;
using System.Linq;
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

        #region TODOS

        [HttpGet]
        public ActionResult<IEnumerable<Todo>> GetTodos() {
            return Ok(_services.GetTodosHeader());
        }

        [HttpGet("{id}")]
        public ActionResult<Todo> GetTodo(int id) {
            var todo = _services.GetTodo(id);
            if (todo == null) return NotFound();
            return Ok(todo);
        }

        [HttpPost]
        public ActionResult<Todo> PostTodo(Todo todo) {
            var todos = _services.AddPost(todo);
            if (todos == null) return NotFound();
            return Ok(todos);
        }

        [HttpPut("{id}")]
        public ActionResult<Todo> PutTodo(int id, Todo todo) {
            if (id != todo.ID) return BadRequest();
            _services.PutTodo(todo);
            return Ok(todo);
        }

        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Todo>> DeleteTodo(int id) {
            if (!_services.DeleteTodo(id)) return NotFound();
            return GetTodos();
        }

        [HttpGet("all")]
        public ActionResult<IEnumerable<Todo>> GetAll() {
            var todos = _services.GetAll();
            if (!todos.Any()) return NotFound();
            return Ok(todos);
        }

        #endregion

        #region ITEMS

        [HttpGet("{id}/items")]
        public ActionResult<IEnumerable<Item>> GetItems(int id) {
            var items = _services.GetItemsFromTodo(id);
            if (items == null) return NotFound();
            return Ok(items);
        }

        [HttpPost("{id}/items")]
        public ActionResult<IEnumerable<Item>> PostItem(Item item) {
            var items = _services.AddItem(item.TodoId, item);
            if (items == null) return NotFound();
            return Ok(items);
        }

        [HttpPut("{todoId}/items/{itemId}")]
        public ActionResult<Item> PutItem(int todoId, int itemId, Item item) {
            if (itemId != item.ItemId) return BadRequest();
            _services.PutItem(item);
            return Ok(item);
        }

        [HttpDelete("{todoId}/items/{itemId}")]
        public ActionResult<Todo> DeleteItem(int todoId, int itemId) {
            if (!_services.DeleteItem(itemId)) return NotFound();
            return GetTodo(todoId);
        }
        
        #endregion

        #region Miscellaneous

        [HttpGet("About")]
        public ContentResult About() {
            return Content("Todo list simple réalisé pour m'entrainer avec les APIs");
        }

        #endregion
    }
}
