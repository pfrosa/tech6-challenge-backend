using System.Collections.Generic;
using tech6_challenge_backend.Models;

namespace tech6_challenge_backend.Data
{
    public interface  ITodoRepo{
        IEnumerable<Todo> GetAllTodos();
        Todo GetTodoById(int id);
        
    }
}