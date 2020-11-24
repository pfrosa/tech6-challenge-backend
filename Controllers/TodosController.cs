using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using tech6_challenge_backend.Data;
using tech6_challenge_backend.Models;

namespace tech6_challenge_backend.Controllers
{
    [Route("/api/todo")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepo _repo;

        public TodosController(ITodoRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Todo>> GetAllTodos()
        {
            return Ok(_repo.GetAllTodos());
        }

        [HttpGet("{id}")]
        public ActionResult<Todo> GetTodoById(int id)
        {
            return Ok(_repo.GetTodoById(id));
        }

        [HttpPost]
        public ActionResult<Todo> CreateTodo(Todo todo)
        {
            return Created("", _repo.CreateTodo(todo));
        }

        [HttpPut("{id}")]
        public ActionResult<Todo> UpdateTodo(int id, Todo todo)
        {

            var found = _repo.GetTodoById(id);
            if (found == null)
            {
                return NotFound();
            }
            else
            {
                found.Content = todo.Content;
                _repo.UpdateTodo(found);
                return Ok();
            }

        }

        [HttpDelete("{id}")]
        public ActionResult DeleteTodo(int id)
        {
            var found = _repo.GetTodoById(id);
            if (found == null)
            {
                return NotFound();
            }
            else
            {
                _repo.DeleteTodo(found);
                return Ok();
            }
        }
    }
}