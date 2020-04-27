using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagItems.Model
{
    public interface IActivity
    {
        public Guid ActivityId { get; set; }
        public string ActivityDisplayId { get; set; }

        public string Description {get;set;}
    }
}
