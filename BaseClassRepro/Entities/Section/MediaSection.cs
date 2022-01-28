using BaseClassRepro.Entities.Block;

namespace BaseClassRepro.Entities.Section
{
    public class MediaSection : Section
    {
        public virtual MediaBlock Content { get; set; }
    }
}
