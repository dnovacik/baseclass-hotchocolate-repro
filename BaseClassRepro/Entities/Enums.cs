using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseClassRepro.Entities
{
    public class Enums
    {
        public enum TextType
        {
            None,
            Bold,
            Italic,
            Underline
        }

        public enum BlockType
        {
            Divider,
            Media,
            Text
        }

        public enum DividerType
        {
            Solid,
            Dotted,
            Dashed
        }

        public enum DividerLength
        {
            Short,
            Long
        }
    }
}
