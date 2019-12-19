using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Controllers;

namespace WebApplication1.DataAccess
{
    class ToDoRepository : IToDoRepository
    {
        public async Task<IEnumerable<ToDo>> GetAll()
        {
            return new List<ToDo>();
        }
    }

    class ToDoRepository2 : IToDoRepository
    {
        public async Task<IEnumerable<ToDo>> GetAll()
        {
            return new List<ToDo>();
        }
    }
}