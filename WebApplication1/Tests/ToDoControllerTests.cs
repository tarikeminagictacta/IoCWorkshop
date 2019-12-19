using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Controllers;
using WebApplication1.DataAccess;

namespace WebApplication1.Tests
{
    public class ToDoControllerTests
    {
        public async Task GivenIHave2TodosInDatabase_ControllerSHoulREturn2()
        {
            var controller = new ToDoController(new MockToDoRepository());

            var response = await controller.GetAll();


        }
    }


    class MockToDoRepository: IToDoRepository
    {
        public async Task<IEnumerable<ToDo>> GetAll()
        {
            return new List<ToDo>
            {
                new ToDo
                {
                    Id=1,
                    Title = "tada1"
                },
                new ToDo
                {
                    Id=2,
                    Title = "tada2"
                }
            };
        }
    }
}
