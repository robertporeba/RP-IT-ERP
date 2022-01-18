using RP_IT_ERP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly Context _context;
        public TaskRepository(Context context)
        {
            _context = context;
        }
        public int AddTask(Domain.Model.Task task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
            return task.Id;
        }

        public void DeleteTask(int taskId)
        {
            var task = _context.Tasks.Find(taskId);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                _context.SaveChanges();
            }
        }

        public IQueryable<Domain.Model.Task> GetAllTasks()
        {
            var tasks = _context.Tasks;
            return tasks;
        }

        public Domain.Model.Task GetTask(int taskId)
        {
            var task = _context.Tasks.FirstOrDefault(a => a.Id == taskId);
            return task;
        }

        public void UpdateTask(Domain.Model.Task task)
        {
            _context.Tasks.Update(task);
            _context.SaveChanges();
        }
    }
}