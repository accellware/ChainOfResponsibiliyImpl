using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRespImpl.Models
{
    public class Company
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
