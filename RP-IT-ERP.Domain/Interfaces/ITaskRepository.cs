using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Domain.Interfaces
{
    public interface ITaskRepository
    {
        int AddTask(RP_IT_ERP.Domain.Model.Task task);
    }
}
