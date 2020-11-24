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
        private readonly TodoRepo repo = new TodoRepo();

        [HttpGet]
        public ActionResult<IEnumerable<Todo>> GetAllTodos()
        {
            return Ok(repo.GetAllTodos());
        }

        [HttpGet("{id}")]
        public ActionResult<Todo> GetTodoById(int id)
        {
            return Ok(repo.GetTodoById(id));
        }
    }
}