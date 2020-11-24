using System.Collections.Generic;
using tech6_challenge_backend.Models;

namespace tech6_challenge_backend.Data
{
    public class TodoRepo : ITodoRepo
    {
        public IEnumerable<Todo> GetAllTodos()
        {
            return new List<Todo>{
                new Todo{Id=0, Content="FOOO"},
                new Todo{Id=1, Content="Bar"},
                new Todo{Id=2, Content="Terceiro TODO"}
            };
        }

        public Todo GetTodoById(int id)
        {
            return new Todo { Id = 0, Content = "FOOO" };
        }
    }
}