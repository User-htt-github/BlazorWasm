using Blazor.API.Data;
using Microsoft.EntityFrameworkCore;

namespace Blazor.API.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly BlazorDbContext _context;

        public TaskRepository(BlazorDbContext context)
        {
            _context = context;
        }

        public async Task<Entities.Task> Create(Entities.Task task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
            return task;
        }

        public async Task<Entities.Task> Delete(Entities.Task task)
        {
            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();
            return task;

        }

        public async Task<IEnumerable<Entities.Task>> GetAllTasks()
        {
            return await _context.Tasks.ToListAsync();
        }

        public async Task<Entities.Task> GetById(Guid id)
        {
            return await _context.Tasks.FindAsync(id);
        }

        public async Task<Entities.Task> Update(Guid id, Entities.Task task)
        {
            _context.Tasks.Update(task);
            await _context.SaveChangesAsync();
            return task;
        }
    }
}
