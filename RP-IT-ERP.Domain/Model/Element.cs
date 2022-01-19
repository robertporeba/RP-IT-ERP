using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Domain.Model
{
    [Table("Element")]
    public class Element
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public int TaskId { get; set; }

        public virtual ICollection<Task> Task { get; set; }

    }
}
