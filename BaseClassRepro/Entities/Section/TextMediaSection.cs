using System.Collections.Generic;

namespace BaseClassRepro.Entities.Section
{
    public class TextMediaSection : Section
    {
        public virtual ICollection<Block.Block> Content { get; set; }
    }
}
