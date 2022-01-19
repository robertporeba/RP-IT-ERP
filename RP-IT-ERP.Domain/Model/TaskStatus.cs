using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Domain.Model
{
    [Table("TaskStatus")]
    public class TaskStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual Task Task { get; set; }
    }
}
