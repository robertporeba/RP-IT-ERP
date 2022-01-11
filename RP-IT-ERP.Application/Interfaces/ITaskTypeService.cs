using RP_IT_ERP.Application.ViewModels.TaskType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Application.Interfaces
{
    public interface ITaskTypeService
    {
        int AddTaskType(AddTaskTypeVm taskType);
    }
}
