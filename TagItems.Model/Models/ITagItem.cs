using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagItems.Model
{
    public interface ITagItem
    {
        public Guid TagItemId { get; set; } // should id be guid or string?
        public string TagItemDisplayId {get;set; } // should id be string or number?
        public string Description { get; set; }
        public Guid EmployeeAssigned { get; set; } // should be such a field(?)
        public string Status { get; set; } // shoud be one of a list of pre defined status constants
        public List<IActivity> Activities { get; }
        public decimal Price { get; set; }
    }
}
