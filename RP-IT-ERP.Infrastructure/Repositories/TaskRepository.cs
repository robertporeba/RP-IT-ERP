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
    }
}
