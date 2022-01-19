using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Domain.Model
{
    [Table("Task")]
    public class Task
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string Name { get; set; }
        public int ClientId { get; set; }
        public int TaskStatusId { get; set; }
        public int TaskTypeId { get; set; }

        public virtual Element Element { get; set; }

        public virtual ICollection<TaskStatus> TaskStatus { get; set; }
        public virtual ICollection<TaskType> TaskType { get; set; }
        public virtual ICollection<Client> Client { get; set; }
    }
}
