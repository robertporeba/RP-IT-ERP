using RP_IT_ERP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Infrastructure.Repositories
{
    public class TaskStatusRepository : ITaskStatusRepository
    {
        private readonly Context _context;
        public TaskStatusRepository(Context context)
        {
            _context = context;
        }
        public int AddTaskStatus(RP_IT_ERP.Domain.Model.TaskStatus taskStatus)
        {
            _context.TaskStatuses.Add(taskStatus);
            _context.SaveChanges();
            return taskStatus.Id;
        }
    }
}
