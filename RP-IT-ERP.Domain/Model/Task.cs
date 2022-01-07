using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Domain.Model
{
    class Task
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string Name { get; set; }
        public int ClientId { get; set; }
        public int TaskStatusId { get; set; }
        public int TaskTypeId { get; set; }
    }
}
