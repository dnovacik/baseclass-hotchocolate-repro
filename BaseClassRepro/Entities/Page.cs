using BaseClassRepro.Entities.Section;
using BaseClassRepro.Types.Input.Section;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BaseClassRepro.Entities
{
    public class Page
    {
        public Guid Id { get; set; }
        [NotMapped]
        public virtual ICollection<SectionInput> SectionsGQL { get; set; }
            = new List<SectionInput>();
        public virtual ICollection<Section.Section> Sections { get; set; }
    }
}
