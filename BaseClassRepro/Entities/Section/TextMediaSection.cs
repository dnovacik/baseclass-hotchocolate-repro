using BaseClassRepro.Types.Input.Block;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaseClassRepro.Entities.Section
{
    public class TextMediaSection : Section
    {
        [NotMapped]
        public virtual ICollection<BlockInput> ContentGQL { get; set; }
            = new List<BlockInput>();
        public virtual ICollection<Block.Block> Content { get; set; }
    }
}
