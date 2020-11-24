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
    }
}