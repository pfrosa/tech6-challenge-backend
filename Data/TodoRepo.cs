using System.Collections.Generic;
using System.Linq;
using tech6_challenge_backend.Models;

namespace tech6_challenge_backend.Data
{
    public class TodoRepo : ITodoRepo
    {
        private readonly TodoContext _context;

        public TodoRepo(TodoContext context)
        {
            _context = context;
        }

        public IEnumerable<Todo> GetAllTodos()
        {
            return _context.Todos.ToList();
        }

        public Todo GetTodoById(int id)
        {
            return _context.Todos.FirstOrDefault( x => x.Id == id);
        }


        public Todo CreateTodo(Todo todo){
            _context.Todos.Add(todo);
            _context.SaveChanges();
            return todo;
        }

        public void DeleteTodo(Todo todo){
            _context.Todos.Remove(todo);
            _context.SaveChanges();
        }

        public Todo UpdateTodo(Todo todo)
        {
            _context.Todos.Update(todo);
            _context.SaveChanges();
             return todo;
        }
    }
}