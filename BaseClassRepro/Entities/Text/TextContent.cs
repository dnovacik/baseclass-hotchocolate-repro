using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseClassRepro.Entities.Text
{
    public class TextContent
    {
        public Guid Id { get; set; }
        public virtual TextContentValue TextContentValue { get; set; }
    }
}
