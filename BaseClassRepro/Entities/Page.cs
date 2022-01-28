using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseClassRepro.Entities
{
    public class Page
    {
        public Guid Id { get; set; }
        public virtual ICollection<Section.Section> Sections { get; set; }
    }
}
