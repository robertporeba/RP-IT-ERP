using RP_IT_ERP.Application.ViewModels.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Application.Interfaces
{
    public interface ITaskService
    {
        int AddTask(AddTaskVm task);
    }
}
