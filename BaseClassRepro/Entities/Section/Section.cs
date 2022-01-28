using System;

namespace BaseClassRepro.Entities.Section
{
    public class Section : ISection
    {
        public Guid Id { get; set; }
        public virtual Headline.Headline Title { get; set; }
    }
}
