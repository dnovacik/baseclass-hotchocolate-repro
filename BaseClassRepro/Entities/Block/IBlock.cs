using System;
using static BaseClassRepro.Entities.Enums;

namespace BaseClassRepro.Entities.Block
{
    public interface IBlock
    {
        public Guid Id { get; set; }
        public BlockType Type { get; set; }
    }
}
