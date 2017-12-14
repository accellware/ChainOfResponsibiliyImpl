using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRespImpl.Models
{
    public class Employee
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public string Identity { get; set; }

        public string Cell { get; set; }

        [ForeignKey("Company")]
        public Guid CompanyId { get; set; }

        public Company Company { get; set; }
    }
}
