using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BaseClassRepro.Entities.Enums;

namespace BaseClassRepro.Entities.Block
{
    public class MediaBlock : Block
    {
        public virtual Media.Media Content { get; set; }
    }
}
