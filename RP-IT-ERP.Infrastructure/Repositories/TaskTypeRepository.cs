using RP_IT_ERP.Domain.Interfaces;
using RP_IT_ERP.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Infrastructure.Repositories
{
    public class TaskTypeRepository : ITaskTypeRepository
    {
        private readonly Context _context;
        public TaskTypeRepository(Context context)
        {
            _context = context;
        }
        public int AddTaskType(TaskType taskType)
        {
            _context.TaskTypes.Add(taskType);
            _context.SaveChanges();
            return taskType.Id;
        }
    }
}
