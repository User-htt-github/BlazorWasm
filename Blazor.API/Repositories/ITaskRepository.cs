using Task = Blazor.API.Entities.Task;

namespace Blazor.API.Repositories
{
    public interface ITaskRepository
    {
        Task<IEnumerable<Task>> GetAllTasks();
        Task<Task> Create(Task task);
        Task<Task> Update(Guid id, Task task);
        Task<Task> Delete(Task task);
        Task<Task> GetById(Guid id);
    }
}
