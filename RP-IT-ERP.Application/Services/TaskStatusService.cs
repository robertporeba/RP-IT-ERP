using AutoMapper;
using AutoMapper.QueryableExtensions;
using RP_IT_ERP.Application.Interfaces;
using RP_IT_ERP.Application.ViewModels.TaskStatus;
using RP_IT_ERP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Application.Services
{
    public class TaskStatusService : ITaskStatusService
    {
        private readonly ITaskStatusRepository _taskStatusRepository;
        private readonly IMapper _mapper;
        public TaskStatusService(IMapper mapper, ITaskStatusRepository taskStatusRepository)
        {
            _taskStatusRepository = taskStatusRepository;
            _mapper = mapper;
        }

        public int AddTaskStatus(AddTaskStatusVm taskStatus)
        {
            var taskStatusDto = _mapper.Map<RP_IT_ERP.Domain.Model.TaskStatus>(taskStatus);
            var id = _taskStatusRepository.AddTaskStatus(taskStatusDto);
            return id;
        }

        public void DeleteTaskStatus(int taskStatusId)
        {
            _taskStatusRepository.DeleteTaskStatus(taskStatusId);
        }

        public ListGetTaskStatuesVm GetAlltaskStatuses()
        {
            var taskStatuses = _taskStatusRepository.GetAlltaskStatuses().ProjectTo<GetTaskStatuesVm>(_mapper.ConfigurationProvider).ToList();
            var taskStatusesList = new ListGetTaskStatuesVm()
            {
                TaskStatuses = taskStatuses
            };
            return taskStatusesList;
        }
    }
}