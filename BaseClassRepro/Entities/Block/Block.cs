using System;

namespace BaseClassRepro.Entities.Block
{
    public class Block : IBlock
    {
        public Guid Id { get; set; }
        public Enums.BlockType Type { get; set; }
    }
}
