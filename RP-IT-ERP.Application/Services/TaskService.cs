using RP_IT_ERP.Application.Interfaces;
using RP_IT_ERP.Application.ViewModels.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using RP_IT_ERP.Domain.Interfaces;

namespace RP_IT_ERP.Application.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IMapper _mapper;
        public TaskService(IMapper mapper, ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
            _mapper = mapper;
        }

        public int AddTask(AddTaskVm task)
        {
            var taskDto = _mapper.Map<RP_IT_ERP.Domain.Model.Task>(task);
            var id = _taskRepository.AddTask(taskDto);
            return id;
        }
    }
}
