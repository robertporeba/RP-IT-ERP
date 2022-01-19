using AutoMapper;
using RP_IT_ERP.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Application.ViewModels.Task
{
    public class UpdateTaskVm : IMapFrom<RP_IT_ERP.Domain.Model.Task>
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string Name { get; set; }
        public int ClientId { get; set; }
        public int TaskStatusId { get; set; }
        public int TaskTypeId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<RP_IT_ERP.Domain.Model.Task, UpdateTaskVm>().ReverseMap();
        }
    }
}
