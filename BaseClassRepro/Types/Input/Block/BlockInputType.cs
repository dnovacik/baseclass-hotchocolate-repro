using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseClassRepro.Entities.Block;
using HotChocolate.Types;

namespace BaseClassRepro.Types.Input.Block
{
    public class BlockInputType : InputObjectType<BlockInput>
    {
        protected override void Configure(IInputObjectTypeDescriptor<BlockInput> descriptor)
        {
            descriptor
                .Name(nameof(BlockInputType))
                .OneOf();

            descriptor
                .Ignore(f => f.Value);

            descriptor
                .Field(f => f.Divider)
                .Type<DividerBlockInputType>();

            descriptor
                .Field(f => f.Media)
                .Type<MediaBlockInputType>();

            descriptor
                .Field(f => f.Text)
                .Type<TextBlockInputType>();
        }
    }

#nullable enable
    public class BlockInput
    {
        public DividerBlock? Divider { get; set; }
        public MediaBlock? Media { get; set; }
        public TextBlock? Text { get; set; }

        public Entities.Block.Block Value => Divider != null
            ? Divider
            : Media != null
                ? Media
                : Text;
    }
#nullable disable
}
