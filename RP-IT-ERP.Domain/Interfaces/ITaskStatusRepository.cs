﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Domain.Interfaces
{
    public interface ITaskStatusRepository
    {
        int AddTaskStatus(RP_IT_ERP.Domain.Model.TaskStatus taskStatus);
    }
}