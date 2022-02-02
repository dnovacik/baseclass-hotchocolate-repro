using BaseClassRepro.Entities.Block;
using BaseClassRepro.Types.Output.Media;
using HotChocolate.Types;
using static BaseClassRepro.Types.EnumTypes;

namespace BaseClassRepro.Types.Output.Block
{
    public sealed class MediaBlockType : ObjectType<MediaBlock>
    {
        protected override void Configure(IObjectTypeDescriptor<MediaBlock> descriptor)
        {
            descriptor
                .Name(nameof(MediaBlockType));

            descriptor
                .Field(f => f.Id)
                .Type<NonNullType<UuidType>>();

            descriptor
                .Field(f => f.Type)
                .Type<BlockTypeEnumType>();

            descriptor
                .Field(f => f.Content)
                .Type<NonNullType<MediaType>>();
        }
    }
}
