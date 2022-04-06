using RP_IT_ERP.Domain.Interfaces;
using RP_IT_ERP.Domain.Model;
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

        public void DeleteTaskStatus(int taskStatusId)
        {
            var taskStatus = _context.TaskStatuses.Find(taskStatusId);
            if (taskStatus != null)
            {
                _context.TaskStatuses.Remove(taskStatus);
                _context.SaveChanges();
            }
        }

        public IQueryable<Domain.Model.TaskStatus> GetAlltaskStatuses()
        {
            var taskStatuses = _context.TaskStatuses;
            return taskStatuses;
        }
    }
}