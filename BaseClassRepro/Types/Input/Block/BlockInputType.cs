using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Types;

namespace BaseClassRepro.Types.Input.Block
{
    public class BlockInputType : InputObjectType
    {
        protected override void Configure(IInputObjectTypeDescriptor descriptor)
        {
            descriptor
                .Name(nameof(BlockInputType))
                .OneOf();

            descriptor
                .Field("divider")
                .Type<DividerBlockInputType>();

            descriptor
                .Field("media")
                .Type<MediaBlockInputType>();

            descriptor
                .Field("text")
                .Type<TextBlockInputType>();
        }
    }
}
