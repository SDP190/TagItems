using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagItems.Model
{
    public interface IItem
    {
        public Guid ItemId { get; set; }
        public decimal Cost {get;set;}


    }
}
