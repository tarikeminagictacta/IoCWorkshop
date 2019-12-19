using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DataAccess;

namespace WebApplication1.Controllers
{
    [Route("api/todos")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoRepository _toDoRepository;


        public ToDoController(IToDoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            //var results = new List<ToDo>();
            //foreach (var repository in _toDoRepository)
            //{
            //    results.AddRange(await repository.GetAll());
            //}
            var results = await _toDoRepository.GetAll();
            return Ok(results);
        }
    }
}