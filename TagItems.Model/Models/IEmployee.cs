using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagItems.Model
{
    public interface IEmployee
    {
        public Guid EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
    }
}
