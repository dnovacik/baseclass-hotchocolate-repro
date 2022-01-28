using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BaseClassRepro.Entities.Enums;

namespace BaseClassRepro.Entities.Text
{
    public class TextContentValue
    {
        public Guid Id { get; set; }
        public TextType Type { get; set; }
        public string Text { get; set; }
    }
}
