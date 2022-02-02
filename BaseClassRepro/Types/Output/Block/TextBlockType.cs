using BaseClassRepro.Entities.Block;
using HotChocolate.Types;
using static BaseClassRepro.Types.EnumTypes;

namespace BaseClassRepro.Types.Output.Block
{
    public sealed class TextBlockType : ObjectType<TextBlock>
    {
        protected override void Configure(IObjectTypeDescriptor<TextBlock> descriptor)
        {
            descriptor
                .Name(nameof(TextBlockType));

            descriptor
                .Field(f => f.Id)
                .Type<NonNullType<UuidType>>();

            descriptor
                .Field(f => f.Type)
                .Type<BlockTypeEnumType>();

            descriptor
                .Field(f => f.Content)
                .Type<ListType<TextBlockContentType>>();
        }
    }
}
