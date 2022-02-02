using BaseClassRepro.Entities.Block;
using System;

namespace BaseClassRepro.Entities.Section
{
    public class MediaSection : Section
    {
        public virtual MediaBlock Content { get; set; }
    }
}
