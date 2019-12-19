using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Controllers;

namespace WebApplication1.DataAccess
{
    public interface IToDoRepository
    {
        Task<IEnumerable<ToDo>> GetAll();
    }
}
