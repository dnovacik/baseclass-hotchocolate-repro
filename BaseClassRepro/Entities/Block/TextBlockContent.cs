using BaseClassRepro.Entities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseClassRepro.Entities.Block
{
    public class TextBlockContent
    {
        public Guid Id { get; set; }
        public TextContent Text { get; set; }
    }
}
