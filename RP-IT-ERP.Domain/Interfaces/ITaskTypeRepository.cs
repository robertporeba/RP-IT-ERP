﻿using RP_IT_ERP.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Domain.Interfaces
{
    public interface ITaskTypeRepository
    {
        int AddTaskType(TaskType taskType);
        void DeleteTaskType(int taskTypeId);
        IQueryable<TaskType> GetAllTaskTypes();
    }
}
