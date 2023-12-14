using Blazor.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Blazor.API.Controllers
{
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskRepository _taskRepository;

        public TaskController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var tasks = await _taskRepository.GetAllTasks();
            return Ok(tasks);
        }
    }
}
