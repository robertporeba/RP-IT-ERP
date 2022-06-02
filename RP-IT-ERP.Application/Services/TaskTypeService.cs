using AutoMapper;
using AutoMapper.QueryableExtensions;
using RP_IT_ERP.Application.Interfaces;
using RP_IT_ERP.Application.ViewModels.TaskType;
using RP_IT_ERP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Application.Services
{
    public class TaskTypeService : ITaskTypeService
    {
        private readonly ITaskTypeRepository _taskTypeRepository;
        private readonly IMapper _mapper;
        public TaskTypeService(IMapper mapper, ITaskTypeRepository taskTypeRepository)
        {
            _taskTypeRepository = taskTypeRepository;
            _mapper = mapper;
        }

        public int AddTaskType(AddTaskTypeVm taskType)
        {
            var taskTypeDto = _mapper.Map<RP_IT_ERP.Domain.Model.TaskType>(taskType);
            var id = _taskTypeRepository.AddTaskType(taskTypeDto);
            return id;
        }

        public void DeleteTaskType(int taskTypeId)
        {
            _taskTypeRepository.DeleteTaskType(taskTypeId);
        }

        public ListGetTaskTypesVm GetAllTaskTypes()
        {
            var taskTypes = _taskTypeRepository.GetAllTaskTypes().ProjectTo<GetTaskTypesVm>(_mapper.ConfigurationProvider).ToList();
            var taskTypesList = new ListGetTaskTypesVm()
            {
                TaskTypes = taskTypes
            };
            return taskTypesList;
        }
    }
}