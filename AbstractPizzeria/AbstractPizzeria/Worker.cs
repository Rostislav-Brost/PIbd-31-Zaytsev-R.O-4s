using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbstractPizzeria
{
    public class Worker
    {
        public int Id { get; set; }

        [Required]
        public string WorkerFIO { get; set; }

        [ForeignKey("WorkerId")]
        public virtual List<Request> Requests { get; set; }
    }
}
