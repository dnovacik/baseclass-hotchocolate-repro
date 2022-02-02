using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BaseClassRepro.Entities.Enums;

namespace BaseClassRepro.Entities.Block
{
    public class TextBlock : Block
    {
        public Guid Id { get; set; }
        public virtual ICollection<TextBlockContent> Content { get; set; }
        public BlockType Type => BlockType.Text;
    }
}
